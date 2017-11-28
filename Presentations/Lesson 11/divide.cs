public double Divide(double dividend, double divisor) {

    if(divisor == 0)
        throw new Exception("Whoooaaa, you can't divide by zero....");

    return (double) dividend / divisor;

}

//[Test]
//[ExpectedException(Exception)]
//public void DivideByZeroTest() {
//    Divide(1, 0);
//}