public double Divide(double i, double j) {

    if(j == 0)
        throw new Exception("Whoooaaa, you can't divide by zero....");

    return (double) i / j;

}

[Test]
[ExpectedException(Exception)]
public void DivideByZeroTest() {
    Divide(1, 0);
}