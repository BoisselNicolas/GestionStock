# Product.cs

## Setters & Getters

public string nom {get; set;}
public int quantite {get; set;}

## Constructor

public Product(){}
public Product(string nom){}
public Product(int quantite){}
public Product(string nom, int quantite){}

## Method

public int AddQuantite(int value){}
public int RemoveQuantite(int value){}


## Règles métiers

 * Un produit ne doit jamais être null
 * Une produit doit avoir une quantite supérieur ou égal à zéro
 * On ne peut pas ajouter une quantite négative
 * On ne peut pas soustraire plus que la quantite existante
