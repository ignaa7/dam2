package DAOs;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DbConnection {

	static String bd = "db_vehiculos";
	static String user = "root";
	static String password = "root";
	static String url = "jdbc:mysql://localhost:3306/" + bd;
	private Connection connection = null;

	public DbConnection() throws SQLException {
		connection = DriverManager.getConnection(url, user, password);
	}

	public Connection getConnection() {
		return connection;
	}

	public void disconnect() throws SQLException {
		if (connection != null) {
			System.err.println("Closing database:[" + connection + "]...");
			connection.close();
			System.err.println("DB disconnect.");
		}
	}
}
