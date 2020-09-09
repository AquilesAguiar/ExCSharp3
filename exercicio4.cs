/* 
Classe Pessoa: Crie uma classe que modele uma pessoa:

    Atributos: nome, idade, peso e altura
    
    Métodos: Envelhercer, engordar, emagrecer, crescer. 
    
    Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.   */


class pessoa{
  //Atributos
  private string nome;
  private double idade,peso,altura;
  
  //Set
  public string retorna_nome(){
    return nome;
  }

  //Set
  public void Envelhercer (double quant_envelhecer){
    
    idade += quant_envelhecer;
    
  }
  
  //Get
  public double retorna_idade(){
    return idade;
  }

  //Set

  public void engordar (double quant_engordar){
     peso += quant_engordar;
     

  }

   //Set
  public void emagrecer (double quant_emagrecer){
    peso -= quant_emagrecer;
   
  }

  //Get
  public double retorna_peso(){
    return peso;
  }

  //Set
  public void crescer (double quant_crescer){
    if (idade>21)
      altura += quant_crescer;
    else
      altura+=0.5;    
  }

  //Get
  public double retorna_altura(){
    return altura;
  }

}