var health = 10;
var TakeDamage : boolean;
function OnTriggerEnter(other : Collider){
    if(other.tag == "Player"){
        TakeDamage = true;
    }
    
    Debug.Log("on trigger!" + other.tag);
    
}
