public int GCD(int i, int j){
  int small, large, remainder;

    if (i <= j)
        small = i;
    else 
        small = j;

    if (i <= j)
        large = j;
    else 
        large = i;
  
    while (small > 0){
        remainder = large % small;
        large = small;
        small = remainder;
    }
  
    return large;
}