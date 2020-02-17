// Tim Sprunger
// p5.js
// March 12, 2018
// This program contains the JavaScript code for the P5 JavaHut Assignment.

var selections = ["Morning Blend", "Light Roast", "Dark Roast", "Java Surprise", "Basic Decaf"];

var prices = [12.00, 12.00, 13.00, 12.00, 15.00];

var totalPrice = 0;
var count = 0;

window.addEventListener("DOMContentLoaded", start);

function start()
{
    console.log("in start function");
    
    document.getElementById("clear").addEventListener("click", clearOrder);
    document.getElementById("order").addEventListener("click", placeOrder);
    
    addCoffee();
}

function addCoffee()
{	
    console.log("in addDrinks function");
    
    for (var x=0; x<selections.length; x++)
	{
		var coffee = document.createElement("div");
        coffee.className = "selection";
        
        var drinkName = document.createElement("h3");
		drinkName.id = "drink" + x;
        drinkName.innerHTML = selections[x] + " - $" + prices[x].toFixed(2);

		var quantityText = document.createElement("p");
        quantityText.innerHTML = "Quantity: ";
		
        var quantityValue = document.createElement("input");
        quantityValue.type = "input";
		quantityValue.id = "quantity" + x;
		quantityValue.size = 10;
		quantityValue.value = 1;
        
        var addButton = document.createElement("button")
        addButton.value = x;
		addButton.innerHTML = "Add"; 
        addButton.addEventListener("click", UpdateCart); 
        
        document.getElementById("coffee").appendChild(coffee);
        coffee.appendChild(drinkName);
        coffee.appendChild(quantityText);
        quantityText.appendChild(quantityValue);
        quantityText.appendChild(addButton);
	}
}

function UpdateCart() 
{
    console.log("in updateCart function");
    
    var quantityValue = document.getElementById("quantity" + this.value);
    
    if (document.getElementById("items").innerHTML == "<li>Your cart is empty</li>")
    {
        document.getElementById("items").innerHTML = "";
    }
    
    if ((quantityValue.value > 100) || (quantityValue.value < 1))
    {
        alert("Error--Invalid Quantity Entered--Valid Quantity Range is 1 to 100");
        quantityValue.value = 1;
        return;
    }
    
    var drinkName = selections[this.value]; 
    var drinkQty = parseInt(quantityValue.value);

    var nextDrink = document.createElement("li");
    nextDrink.innerHTML = drinkName + " - " + drinkQty;

    document.getElementById("items").appendChild(nextDrink);
    
    totalPrice = parseInt(totalPrice);
    var intValue = parseInt(prices[this.value]);
    totalPrice = totalPrice + parseInt(intValue * drinkQty); 
    totalPrice = totalPrice.toFixed(2);
    document.getElementById("total").innerHTML = "$" + totalPrice;
    
    count = count + drinkQty;
    document.getElementById("cartHeading").innerHTML = "Order - Qty: " + count;
    
    quantityValue.value = 1;
}

function clearOrder() 
{
    console.log("in clearOrder function");

	var cartItems = document.getElementById("items");
	while ( cartItems.hasChildNodes() ) 
    {
		cartItems.removeChild(cartItems.firstChild)
	}

	for (var x = 0; x < selections.length; x++) 
    {
		var nextInput = document.getElementById("quantity" + x).value = 1;
	}
    
    document.getElementById("items").innerHTML = "Your cart is empty";
	
    totalPrice = 0;
    totalPrice = totalPrice.toFixed(2)
	document.getElementById("total").innerHTML = "$" + totalPrice
}

function placeOrder(){
    console.log("in placeOrder function");
    alert("Order Total $" + totalPrice + " Thank you!");
}
