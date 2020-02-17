/*
	FinalProject.js
	Tim Sprunger
	May 10, 2018
	JavaHut Assignment Using MooTools JavaScript Library
*/	

var photos = ["coffee1.jpg", "coffee2.jpg", "coffee3.jpg", "coffee4.jpg", "coffee5.jpg"];
var selections = ["Morning Blend", "Light Roast", "Dark Roast", "Java Surprise", "Basic Decaf"];
var prices = [12.00, 12.00, 13.00, 12.00, 15.00];

var totalPrice = 0;
var count = 0;

window.addEvent('domready', function() 
{   
    $('clear').addEvent('click', clearOrder);
    $('order').addEvent('click', placeOrder);    
    addCoffee(); 
});

function addCoffee()
{    
    for (var x=0; x<selections.length; x++)
    {
        var coffee = new Element('div.selection');
        
        var drinkName = new Element('h3', {
            id: 'drink' + x
        });
        
        drinkName.set('html', selections[x] + ' - $' + prices[x].toFixed(2));  
        
        var quantityText = new Element('p');
        quantityText.set('html', 'Quantity: ');
        
        var quantityValue = new Element('input', {
            type: 'input',
            id: 'quantity' + x,
            size: 10,
            value: 1                                                      
        });
        
        var addButton = new Element('button', {
            value: x,
        });
        
        addButton.set('html', 'Add');
        addButton.addEvent('click', updateCart);
        
        $('coffee').append(coffee);
        coffee.append(drinkName);
        coffee.append(quantityText);
        quantityText.append(quantityValue);
        quantityText.append(addButton);
    }   
}

function updateCart()
{        
    var quantityValue = $('quantity' + this.value);
    
    if( $('items').get('html') == '<li>Your cart is empty</li>' )
    {
        $('items').set('html', '');
    }
    
    if( $('items').get('html') == 'Your cart is empty' )
    {
        $('items').set('html', '');
    }
    
    if ( (quantityValue.get('value') > 100) || (quantityValue.get('value') < 1) )
    {
        alert("Error——Invalid Quantity——Valid Quantity Range is 1 to 100");
        quantityValue.set('value', 1);
        return;
    }
    
    var drinkName = selections[this.value];
    var drinkQty = parseInt( quantityValue.get('value') );
    
    var nextDrink = new Element('li');
    nextDrink.set('html', drinkName + ' - ' + drinkQty);
    
    $('items').append(nextDrink);

    totalPrice = parseInt(totalPrice);
    var intValue = parseInt( prices[this.value] );
    totalPrice = totalPrice + parseInt(intValue * drinkQty); 
    totalPrice = totalPrice.toFixed(2);
    $('total').set('html', '$' + totalPrice);
    
    count = count + drinkQty;
    $('cartHeading').set('html', 'Order - Qty: ' + count);
    
    quantityValue.set('value', 1);
    
    $('photo').set( 'src', photos[this.value] );
    
    $('text').setStyle('background-color', '#000000');
    $('coffeeName').set('html', drinkName);
    $('quantity').set('html', "+ " +drinkQty);
}

function clearOrder()
{
    count = 0;
    $('cartHeading').set('html', 'Order - Qty: ' + count);
    
    $('items').set('html', 'Your cart is empty');
    
    $('coffeeName').set('html', '');
    $('quantity').set('html', '');
    $('text').setStyle('background-color', '');


    for (var x=0; x<selections.length; x++) 
    {
        $('quantity' + x).set('value', 1);
	}
        
    totalPrice = 0;
    totalPrice = totalPrice.toFixed(2)
	$('total').set('html', '$' + totalPrice);
}

function placeOrder()
{
    alert('Order Total $' + totalPrice + ' Thank you!');
}