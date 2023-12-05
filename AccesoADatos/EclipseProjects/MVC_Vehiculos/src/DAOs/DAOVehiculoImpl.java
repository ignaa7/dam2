package DAOs;


import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import Recursos.Vehiculo;




public class DAOVehiculoImpl implements IDAOVehiculo {
	
	private List<Vehiculo> falsaBD;
	private static IDAOVehiculo dao=null;
	private DbConnection dbConnection;
	private Connection connection;

	private DAOVehiculoImpl() {
		super();
		try {
			dbConnection = new DbConnection();
			connection = dbConnection.getConnection();
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
	}

	@Override
	public int insertarVehiculo(Vehiculo vehiculo, String nombreUsuario) {
		int idCliente = 0;
				
		String sqlQueryId = "SELECT id FROM clientes WHERE nombre_usuario='" + nombreUsuario + "'";
        try (PreparedStatement statement = connection.prepareStatement(sqlQueryId)) {
            ResultSet resultSet = statement.executeQuery();
            
            while (resultSet.next()) {
                idCliente = resultSet.getInt("id");
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        
		String sqlQuery = "INSERT INTO vehiculos (marca, modelo, matricula, id_cliente) VALUES (?, ?, ?, ?)";
		
        try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
            statement.setString(1, vehiculo.getMarca());
            statement.setString(2, vehiculo.getModelo());
            statement.setString(3, vehiculo.getMatricula());
            statement.setInt(4, idCliente);

            int rowsInserted = statement.executeUpdate();
            if (rowsInserted > 0) {
                return 1;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return 0;
	}
	
	public int modificarVehiculo(String marca, String modelo, String matricula) {
String sqlQuery = "UPDATE vehiculos SET marca = ?, modelo = ? WHERE matricula='" + matricula + "'";
		
        try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
            statement.setString(1, marca);
            statement.setString(2, modelo);

            int rowsInserted = statement.executeUpdate();
            if (rowsInserted > 0) {
                return 1;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return 0;
	}

	

	@Override
	public int eliminarVehiculo(String matricula) {
		String sqlQuery = "DELETE FROM vehiculos WHERE matricula='" + matricula + "'";
		
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

	@Override
	public int eliminarVehiculos(List<Vehiculo> lstVehiculos) {
		
		return 0;
	}

	@Override
	public Vehiculo getVehiculo(String matricula) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<Vehiculo> getVehiculos() {
		List<Vehiculo> vehiculos = new ArrayList<>();

        String sqlQuery = "SELECT * FROM vehiculos";
        try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
            ResultSet resultSet = statement.executeQuery();
            
            while (resultSet.next()) {
                String marca = resultSet.getString("marca");
                String modelo = resultSet.getString("modelo");
                String matricula = resultSet.getString("matricula");
                int idCliente = resultSet.getInt("id_cliente");
                vehiculos.add(new Vehiculo(marca, modelo, matricula, idCliente));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        
        return vehiculos;
	}

	
	public static IDAOVehiculo getInstance() {
	  if (dao== null) dao =new DAOVehiculoImpl();
	  
		return dao;
	}

	@Override
	public int eliminarVehiculo(Vehiculo vehiculo) {
		// TODO Auto-generated method stub
		return 0;
	}

}
