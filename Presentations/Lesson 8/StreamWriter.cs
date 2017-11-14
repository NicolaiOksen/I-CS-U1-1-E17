public static void Main(){
    string str =      "A æ u å æ ø i æ å",                                   
           strEquiv = "A \u00E6 u \u00E5 \u00E6 \u00F8 i \u00E6 \u00E5";
  
    /* MISSING CODE... Oh noo */                                  
                                                                             
    tw1.WriteLine(str);     tw1.WriteLine(strEquiv);                         
    tw2.WriteLine(str);     tw2.WriteLine(strEquiv);                         
    tw3.WriteLine(str);     tw3.WriteLine(strEquiv);

    tw1.Close();                                                             
    tw2.Close();
    tw3.Close();
    
    /* MISSING CODE for next exercise!... Oh noo */                                  

    // Console.WriteLine(tr1.ReadLine());  Console.WriteLine(tr1.ReadLine());  
    // Console.WriteLine(tr2.ReadLine());  Console.WriteLine(tr2.ReadLine());  
    // Console.WriteLine(tr3.ReadLine());  Console.WriteLine(tr3.ReadLine());  

    // tr1.Close();
    // tr2.Close();
    // tr3.Close();
}
