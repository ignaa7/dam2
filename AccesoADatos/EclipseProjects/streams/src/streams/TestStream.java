package streams;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Stream;

public class TestStream {

	public static void main(String[] args) {
		List<Curso> cursos = new ArrayList<Curso>();
		cursos.add(new Curso("Cursos profesional de Java", 6.5f, 50, 200 ));
		cursos.add(new Curso("Cursos profesional de Python", 8.5f, 60, 800 ));
		cursos.add(new Curso("Cursos profesional de DB", 4.5f, 70, 700 ));
		cursos.add(new Curso("Cursos profesional de Android", 7.5f, 10, 400 ));
		cursos.add(new Curso("Cursos profesional de Escritura", 1.5f, 10, 300 ));
		
		//1
		System.out.println("Número de cursos con una duración mayor a 5 horas: " + cursos.stream()
																						.filter(curso -> curso.getDuracion() > 5)
																						.count());
		
		System.out.println();
		
		//2
		System.out.println("Número de cursos con una duración menor a 2 horas: " + cursos.stream()
																						.filter(curso -> curso.getDuracion() < 2)
																						.count());
		
		System.out.println();
		
		//3
		System.out.println("Título de los cursos con una cantidad de vídeos mayor a 50:");
		cursos.stream()
			.filter(curso -> curso.getVideos() > 50)
			.map(Curso::getTitulo)
			.forEach(System.out::println);
		
		System.out.println();
		
		//4
		System.out.println("Título de los 3 cursos con mayor duración:");
		cursos.stream()
			.sorted(Comparator.comparingDouble(Curso::getDuracion).reversed())
			.limit(3)
			.map(Curso::getTitulo)
			.forEach(System.out::println);
		
		System.out.println();
		
		//5
		System.out.println("Duración de todos los cursos:");
		cursos.stream()
			.forEach((curso) -> {
				System.out.println(curso.getTitulo() + ": " + curso.getDuracion() + " horas");
			});
		
		System.out.println();
		
		//6
		System.out.println("Cursos que superan la duración promedia:");
		cursos.stream()
		.filter(curso -> curso.getDuracion() > cursos.stream()
													.mapToDouble(Curso::getDuracion)
													.average().orElse(0.0))
		.map(Curso::getTitulo)
		.forEach(System.out::println);
		
		System.out.println();
		
		//7
		System.out.println("Duración de los cursos que tengan menos de 500 alumnos inscritos");
		cursos.stream()
			.filter(curso -> curso.getAlumnos() < 500)
			.forEach((curso) -> {
				System.out.println(curso.getTitulo() + ": " + curso.getDuracion() + " horas");
			});
		
		System.out.println();
		
		//8
		System.out.println("Curso con mayor duración:");
		cursos.stream()
			.max(Comparator.comparingDouble(Curso::getDuracion))
			.ifPresent(curso -> System.out.println(curso.getTitulo() + ": " + curso.getDuracion() + " horas"));
		
		System.out.println();
		
		//9
		System.out.println("Títulos de todos los cursos:");
		cursos.stream()
			.forEach((curso) -> {
				System.out.println(curso.getTitulo());
			});
	}

}
