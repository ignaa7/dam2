/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DAOs;

import POJOs.Trabajador;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ignac
 */
public class DAOTrabajador {
    private DbConnection dbConnection;
    private Connection connection;

    public DAOTrabajador() {
        try {
            dbConnection = new DbConnection();
            connection = dbConnection.getConnection();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
    
    public List<Trabajador> getTrabajadores(int codigoEmpresa) {
        List<Trabajador> trabajadores = new ArrayList<>();

        String sqlQuery = "SELECT * FROM trabajadores WHERE codigo_empresa=" + codigoEmpresa;
        try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
            ResultSet resultSet = statement.executeQuery();

            while (resultSet.next()) {
                String nombre = resultSet.getString("nombre");
                double sueldo = resultSet.getDouble("sueldo");
                boolean casado = resultSet.getBoolean("casado");
                trabajadores.add(new Trabajador(codigoEmpresa, nombre, sueldo, casado));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return trabajadores;
    }
    
    public int insertarTrabajador(int codigoEmpresa, String nombre, double sueldo, boolean casado) {
        int cont = 0;

        String sqlQueryId = "SELECT codigo FROM empresas WHERE codigo=" + codigoEmpresa;
        try (PreparedStatement statement = connection.prepareStatement(sqlQueryId)) {
            ResultSet resultSet = statement.executeQuery();

            while (resultSet.next()) {
                cont++;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        if (cont > 0) {
            String sqlQuery = "INSERT INTO trabajadores (codigo_empresa, nombre, sueldo, casado) VALUES (?, ?, ?, ?)";

            try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
                statement.setInt(1, codigoEmpresa);
                statement.setString(2, nombre);
                statement.setDouble(3, sueldo);
                statement.setBoolean(4, casado);

                int rowsInserted = statement.executeUpdate();
                if (rowsInserted > 0) {
                    return 1;
                }
            } catch (SQLException e) {
                e.printStackTrace();
            }
        }
        
        return 0;
    }
    
    public boolean comprobarCasados(int codigoEmpresa) {
        String sqlQuery = "SELECT * FROM trabajadores WHERE codigo_empresa=" + codigoEmpresa;
        boolean hayCasado = false;
        
        try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
            ResultSet resultSet = statement.executeQuery();

            while (resultSet.next()) {
                boolean casado = resultSet.getBoolean("casado");
                if (casado) {
                    hayCasado = true;
                }
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return hayCasado;
    }
}
