/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DAOs;

import POJOs.Comunidad;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author dam
 */
public class DAOComunidad {

    private DbConnection dbConnection;
    private Connection connection;

    public DAOComunidad() {
        try {
            dbConnection = new DbConnection();
            connection = dbConnection.getConnection();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
    
    public int insertarComunidad(int codigo, String nombre) {
        String sqlQuery = "INSERT INTO comunidades (codigo, nombre) VALUES (?, ?)";

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

    public int eliminarComunidad(int codigo) {
        String sqlQuery = "DELETE FROM comunidades WHERE codigo=" + codigo;

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

    public List<Comunidad> getComunidades() {
        List<Comunidad> comunidades = new ArrayList<>();

        String sqlQuery = "SELECT * FROM comunidades";
        try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
            ResultSet resultSet = statement.executeQuery();

            while (resultSet.next()) {
                int codigo = resultSet.getInt("codigo");
                String nombre = resultSet.getString("nombre");
                comunidades.add(new Comunidad(codigo, nombre));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return comunidades;
    }

}
