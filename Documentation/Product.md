# Product.cs

## Setters & Getters

public string nom {get; set;}</br>
public int quantite {get; set;}</br>

## Constructor

public Product(){}</br>
public Product(string nom){}</br>
public Product(int quantite){}</br>
public Product(string nom, int quantite){}</br>

## Method

public int AddQuantite(int value){}</br>
public int RemoveQuantite(int value){}</br>


## Règles métiers

 * Un produit ne doit jamais être null</br>
 * Une produit doit avoir une quantite supérieur ou égal à zéro</br>
 * On ne peut pas ajouter une quantite négative</br>
 * On ne peut pas soustraire plus que la quantite existante</br>
