package DAOs;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import Recursos.Cliente;
import Recursos.Vehiculo;

public class DAOCliente {
	private DbConnection dbConnection;
	private Connection connection;
	private static DAOCliente dao = null;
	
	private DAOCliente() {
		try {
			dbConnection = new DbConnection();
			connection = dbConnection.getConnection();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public List<Cliente> getClientes() {
		List<Cliente> clientes = new ArrayList<>();

        String sqlQuery = "SELECT * FROM clientes";
        try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
            ResultSet resultSet = statement.executeQuery();
            
            while (resultSet.next()) {
                String nombreUsuario = resultSet.getString("nombre_usuario");
                clientes.add(new Cliente(nombreUsuario));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        
        return clientes;
	}
	
	public int insertarCliente(String nombreUsuario) {
		String sqlQuery = "INSERT INTO clientes (nombreUsuario) VALUES (?, ?, ?)";
		
        try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
            statement.setString(1, "a");
            statement.setString(2, "a");
            statement.setString(3, "a");

            int rowsInserted = statement.executeUpdate();
            if (rowsInserted > 0) {
                return 1;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return 0;
	}
	
	public static DAOCliente getInstance() {
		  if (dao == null) dao = new DAOCliente();
		  
			return dao;
		}
}
