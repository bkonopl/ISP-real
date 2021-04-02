#include "DDL.h"

int Multiply(int a, int b) {
    return a * b;
}

int Divide(int a, int b) {
    return a / b;
}

int Pow(int a, int power) {

    int value = 1;

    while (power) {
        if(power % 2) value *= a;
        a *= a;
        power /= 2;
    }
    return value;
}