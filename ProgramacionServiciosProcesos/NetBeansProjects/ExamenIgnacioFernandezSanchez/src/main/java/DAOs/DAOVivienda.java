/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DAOs;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 *
 * @author dam
 */
public class DAOVivienda {

    private DbConnection dbConnection;
    private Connection connection;

    public DAOVivienda() {
        try {
            dbConnection = new DbConnection();
            connection = dbConnection.getConnection();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public int insertarVivienda(int codigoComunidad, int piso, String letra, String propietario, int tarifa, boolean moroso) {
        int cont = 0;

        String sqlQueryId = "SELECT codigo FROM comunidades WHERE codigo=" + codigoComunidad;
        try (PreparedStatement statement = connection.prepareStatement(sqlQueryId)) {
            ResultSet resultSet = statement.executeQuery();

            while (resultSet.next()) {
                cont++;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        if (cont > 0) {
            String sqlQuery = "INSERT INTO viviendas (codigo_comunidad, piso, letra, propietario, tarifa, moroso) VALUES (?, ?, ?, ?, ?, ?)";

            try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
                statement.setInt(1, codigoComunidad);
                statement.setInt(2, piso);
                statement.setString(3, letra);
                statement.setString(4, propietario);
                statement.setInt(5, tarifa);
                statement.setBoolean(6, moroso);

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
    
    public boolean comprobarMorosos() {
        String sqlQuery = "SELECT * FROM viviendas";
        boolean hayMoroso = false;
        
        try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
            ResultSet resultSet = statement.executeQuery();

            while (resultSet.next()) {
                boolean moroso = resultSet.getBoolean("moroso");
                if (moroso) {
                    hayMoroso = true;
                }
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return hayMoroso;
    }
}
