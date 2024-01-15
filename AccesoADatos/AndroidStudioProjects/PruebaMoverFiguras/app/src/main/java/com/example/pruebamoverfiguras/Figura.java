package com.example.pruebamoverfiguras;

public abstract class Figura {
    protected int x;
    protected int y;

    public Figura(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public abstract boolean isHovered(int x, int y);
}
