package TestVehiculos;


import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.mockito.Mockito.mock;

import javax.swing.JLabel;
import javax.swing.JTextField;

import org.junit.jupiter.api.BeforeAll;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.Mockito;
import org.junit.jupiter.api.Test;

import Controller.ControllerJuego;
import Recursos.GestionVehiculos;
import Vista.PanelJuego;

class ControllerJuegoTest {
	
	@InjectMocks
	private static ControllerJuego controllerJuego;
	
	@Mock
	private static GestionVehiculos gestionVehiculos;
	
	@Mock
	private static PanelJuego panelJuego;

	@BeforeAll
	static void setUpBeforeClass() throws Exception {
		panelJuego = mock(PanelJuego.class);
		gestionVehiculos = mock(GestionVehiculos.class);
		
		controllerJuego = new ControllerJuego(panelJuego, gestionVehiculos);
		
		panelJuego.etiSecreta = new JLabel("Pulse nuevo para comenzar");
		panelJuego.etiSecreta.setBounds(42, 58, 172, 19);
		
		panelJuego.txtRespuesta = new JTextField();
		panelJuego.txtRespuesta.setBounds(77, 122, 137, 20);
	}

	@Test
	void nuevoCocheTest() {
		Mockito.when(gestionVehiculos.getVehiculo()).thenReturn("coche");
		
		controllerJuego.nuevoCoche();
		
		assertEquals("coche", panelJuego.etiSecreta.getText());
	}
	
	public void comprobarCocheTest() {
		
	}

}
