var isQuitButton = false;
var CameraAnimation : Animation;



function OnMouseEnter()
{
    //change the color of the text
    renderer.material.color = Color.red;
}


function OnMouseExit()
{
    //change the color of the text
    renderer.material.color = Color.white;
}

function OnMouseUp()
{
    //are we dealing with a quit button
    if( isQuitButton )
    {
          //quit the game
          Application.Quit();
    }
    else
    {
          //load level
          Application.LoadLevel(1);
 
 				   
       
    }
}