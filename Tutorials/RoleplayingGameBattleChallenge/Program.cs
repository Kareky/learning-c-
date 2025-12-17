/*  ROLEPLAYING GAME BATTLE CHALLENGE
    You must use either the do-while statement or the while statement as an outer game loop.
    The hero and the monster start with 10 health points.
    All attacks are a value between 1 and 10.
    The hero attacks first.
    Print the amount of health the monster lost and their remaining health.
    If the monster's health is greater than 0, it can attack the hero.
    Print the amount of health the hero lost and their remaining health.
    Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
    Print the winner.
*/
// Creating hero and monster stats
var damage = new Random();
var heroHealth = 10;
var monsterHealth = 10;
var conclusionMessage = "";

do  {
    var heroDamage = damage.Next(1, 11);
    monsterHealth -= heroDamage;

    //Setting health equal to 0 to not display negative numbers
    if (monsterHealth <= 0) {
        monsterHealth = 0;
        conclusionMessage = "Congratulations! You've defeated the monster! We sure need more heroes like you! If you want to join our forces and defeat more monsters, please, come back to us!";
    }

    //Displaying different messages based on damage amount
    if (heroDamage == 10) {
        Console.WriteLine("Woah! What an hit! You've just shreaded that monster for 10 damage and defeated it!");
        break;
    } else if (heroDamage >= 5) {
        Console.WriteLine($"Great hit! You've just hit that monster for {heroDamage} damage. It now has {monsterHealth} health remaining.");
    } else {
        Console.WriteLine($"You hit the monster for {heroDamage} damage. It now has {monsterHealth} health remaining.");
    }    

    if (monsterHealth > 0)  {
        var monsterDamage = damage.Next(1, 11);
        heroHealth -= monsterDamage;

        //Setting health equal to 0 to not display negative numbers
        if (heroHealth <= 0) {
            heroHealth = 0;
            conclusionMessage = "Oh no! The monster has defeated you this time. Don't be discouraged, brave hero! Gather your strength and return to vanquish the beast!";
        }

        //Displaying different messages based on damage amount
        if (monsterDamage == 10) {
            Console.WriteLine("Ouch! That monster just landed a critical hit on you for 10 damage! You've been defeated!");
            break;
        } else if (monsterDamage >= 5) {
            Console.WriteLine($"That monster hit you hard for {monsterDamage} damage. You now have {heroHealth} health remaining.");
        } else {
            Console.WriteLine($"The monster hit you for {monsterDamage} damage. You now have {heroHealth} health remaining.");
        }
    }
} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(conclusionMessage);

