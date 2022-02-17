# Stock.cs

## Setters & Getters

public List<Product> ListProduct {get; set;}</br>

## Variable 

private static Stock _instance;</br>

## Constructor

private Stock () {}</br>

## Method

public static Stock GetInstance(){}</br>
public string addProduct(Product produit){}</br>
public string removeProduct(Product produit){}</br>
public Product GetProduct(String nom){}</br>

## Règles métiers

 * Il ne peut y avoir qu'un seul stock
 * On peut ajouter un produit
 * On peut supprimer un produit
 * On peut récupérer un produit
 * On ne peut pas ajouter un produit déjà existant
 * On ne peut pas supprimer un produit qui n'existe pas 
 * On ne peut pas récupérer un produit qui n'existe pas
