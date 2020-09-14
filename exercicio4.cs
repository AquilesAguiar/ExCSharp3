/* 
Classe Pessoa: Crie uma classe que modele uma pessoa:

    Atributos: nome, idade, peso e altura
    
    Métodos: Envelhercer, engordar, emagrecer, crescer. 
    
    Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.   */


class pessoa{
  //Atributos
  private string nome;
  private double idade,peso,altura;

  
  //Sets

  public void set_nome(string name){
    nome = name;
  }

  public void set_idade(double valor_idade){
    idade = valor_idade;
  }

  public void set_peso(double valor_peso){
    peso = valor_peso;
  }

  public void set_altura(double valor_altura){
    altura = valor_altura;
  }

  
  //Metodos
  
  public void Envelhercer (double quant_envelhecer){
    idade += quant_envelhecer;
    
  }

  public void engordar (double quant_engordar){
     peso += quant_engordar;
  
  }

  public void emagrecer (double quant_emagrecer){
    peso -= quant_emagrecer;
  }

  public void crescer (double quant_crescer){
    if (idade>21)
      altura += quant_crescer;
    else
      altura+=0.5;    
  }

  //-----------------------------------------------------

  //get

  public string retorna_nome(){
    return nome;
  }
  
  public double retorna_idade(){
    return idade;
  }

  public double retorna_peso(){
    return peso;
  }

  public double retorna_altura(){
    return altura;
  }

}