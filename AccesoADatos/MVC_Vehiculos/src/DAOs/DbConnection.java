package DAOs;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DbConnection {

	static String bd = "db_vehiculos";
	static String user = "root";
	static String password = "root";
	static String url = "jdbc:mysql://localhost:3306/" + bd;
	private Connection conn = null;

	public DbConnection() throws SQLException {
		conn = DriverManager.getConnection(url, user, password);
	}

	public Connection getConnection() {
		return conn;
	}

	public void disconnect() throws SQLException {
		if (conn != null) {
			System.err.println("Closing database:[" + conn + "]...");
			conn.close();
			System.err.println("DB disconnect.");
		}
	}
}
