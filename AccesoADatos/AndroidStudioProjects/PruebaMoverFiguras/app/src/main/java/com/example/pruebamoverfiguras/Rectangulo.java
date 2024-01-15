package com.example.pruebamoverfiguras;

public class Rectangulo extends Figura {
    private double width;
    private double height;

    public Rectangulo(int x, int y, double width, double height) {
        super(x, y);
        this.width = width;
        this.height = height;
    }

    @Override
    public boolean isHovered(int x, int y) {
        return x >= this.x && x <= this.x + width && y >= this.y && y <= this.y + height;
    }
}
