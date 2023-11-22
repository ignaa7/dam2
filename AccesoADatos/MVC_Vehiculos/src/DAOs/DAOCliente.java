package DAOs;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import Recursos.Vehiculo;

public class DAOCliente {
	private DbConnection dbConnection;
	private Connection connection;
	
	private DAOCliente() {
		try {
			dbConnection = new DbConnection();
			connection = dbConnection.getConnection();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public int insertarCliente(String nombreUsuario) {
		String sqlQuery = "INSERT INTO clientes (nombreUsuario) VALUES (?, ?, ?)";
		
        try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
            statement.setString(1, vehiculo.getMarca());
            statement.setString(2, vehiculo.getModelo());
            statement.setString(3, vehiculo.getMatricula());

            int rowsInserted = statement.executeUpdate();
            if (rowsInserted > 0) {
                return 1;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return 0;
	}
	
	public static IDAOVehiculo getInstance() {
		  if (dao== null) dao =new DAOVehiculoImpl();
		  
			return dao;
		}
}
