using System;
namespace dle_StockholdSyndrome
{
    public class Items
    {
        //branching prompts
        public static string personPrompt = "An army official in grey uniform is sitting on the right of the bar near the entrance gets up promptly to address you. While on the opposite side, an average looking citizens calls to you as a friend. Who will you go to?";
        public static string officerPrompt = "Walking to the officer, he explains to you about the enlisting of new military personel and the cause that the government really had in mind. The production and use of a mindcontrolling drug to boost productivity, but in return their free will. With how you feel, you can choose to attack him right then and there or follow up by going with him to the facility.";
        public static string recruiterPrompt = "You chose to sit with your so-called friend when he reveals to you that he is a member of a new resistance. He was looking for new recruits to join their cause. Interested in joining or would rather dig deeper into what it is about?";
        public static string killedPrompt = "After attacking the officer you're confronted by other officers. Make a stand or grab the syringe from the officer's jacket";
        public static string facilityPrompt = "You followed him to the facility. One final time he offers the opportunity to join their enforcement squadron. Do you wish to join or make a stand here with the fire extinguisher?";
        public static string enlistPrompt = "Showing interest in enlisting, he offers two different positions. On one hand, tech operatives are needed to acquire the formula for the drug compound. Whilst on the other, the rebellion base is getting word of an attack, they need soldiers, Which would you like?";
        public static string reportPrompt = "Questioning their authority in the city, you can either choose to report him to the officer in the bar or you could just walk away peacefully.";

        //options 
        public static string[] person = { " attend to the officer", " acknowledge the so-called friend" };
        public static string[] officer = { " attack him right there", " agree to follow him to the facility" };
        public static string[] recruiter = { " enlist with the rebellion", " interogate him for more information" };
        public static string[] killed = { " engage in combat with other officers", " take the drug infront of you" };
        public static string[] facility = { " join their militia", " wreak havoc once inside" };
        public static string[] enlist = { " join as a tech operative", " join as an infantry troop" };
        public static string[] leech = { " report him to the authorities", " walk away" };

        //resulting narratives
        public static string combatFinal = "You have died after making a final, epic standoff.";
        public static string drugFinal = "Now you've dug into the officers jacket to reveal a syringe which you inject yourself with. Can't recall what happens then";
        public static string militaryFinal = "Now officially joining their enforcement team, you admit to the autrocities they've committed and you have no where else to go besides comply.";
        public static string havocFinal = "You learned about what they plan to do and you can't comply. You grab a fire extinguisher to escape but you are detained and forced to take the drug. Can't recall what happens then";
        public static string techFinal = "You have joined as a tech op. With years in the study, your team breaks in and steals the compound formula to creat an antidote";
        public static string infantryFinal = "You have joined as an infantry soldier. Only a month after your enlisting. The base is under attack, ";
        public static string reportFinal = "After learning more about this scandalous operation, you reported him to the officer just on the other side. You'll regret it forever";
        public static string leaveFinal = "Finally, you choose walk away. You don't want to get involed. Can't recall what happens then";
    }
}
