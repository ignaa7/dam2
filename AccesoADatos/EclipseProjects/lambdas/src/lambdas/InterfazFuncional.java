package lambdas;

@FunctionalInterface
public interface InterfazFuncional<T> {
	T calcular(int... numbers);
}
