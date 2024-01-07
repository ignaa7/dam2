/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DAOs;

import POJOs.Empresa;
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
public class DAOEmpresa {
    private DbConnection dbConnection;
    private Connection connection;

    public DAOEmpresa() {
        try {
            dbConnection = new DbConnection();
            connection = dbConnection.getConnection();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
    
    public List<Empresa> getEmpresas() {
        List<Empresa> empresas = new ArrayList<>();

        String sqlQuery = "SELECT * FROM empresas";
        try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
            ResultSet resultSet = statement.executeQuery();

            while (resultSet.next()) {
                int codigo = resultSet.getInt("codigo");
                String nombre = resultSet.getString("nombre");
                empresas.add(new Empresa(codigo, nombre));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return empresas;
    }
    
    public int insertarEmpresa(int codigo, String nombre) {
        String sqlQuery = "INSERT INTO empresas (codigo, nombre) VALUES (?, ?)";

            try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
                statement.setInt(1, codigo);
                statement.setString(2, nombre);

                int rowsInserted = statement.executeUpdate();
                if (rowsInserted > 0) {
                    return 1;
                }
            } catch (SQLException e) {
                e.printStackTrace();
            }
        
        return 0;
    }

    public int eliminarEmpresa(int codigo) {
        String sqlQuery = "DELETE FROM empresas WHERE codigo=" + codigo;

        try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {

            int rowsDeleted = statement.executeUpdate();
            if (rowsDeleted > 0) {
                return 1;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return 0;
    }
}
