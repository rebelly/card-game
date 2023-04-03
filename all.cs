using System;
class player
{
	int[] deck = new int[36];
	public static int last_card(int[] deck, int j)
	{
		for (int i = deck.Length - 1; i > -1; i++)
		{
			if (deck[i] != 0) return i - j;
		}
		return 0;
	}
	public void war(player sec, int num1, int num2) {

		num1++;
		num2++;
		int card1 = this.deck[num1];
		int card2 = sec.deck[num2];
		if (card1 > card2)
		{
			this.deck[num1 + 1] = card2;
			sec.deck[num2] = 0;
		}
		else if (card1 < card2)
		{
			sec.deck[num2 + 1] = card1;
			this.deck[num1] = 0;
		}
        else
        {
			war(sec, num1, num2);
        }

	}
	public void move(player sec)
	{
		int num1 = last_card(this.deck, 0);
		int num2 = last_card(sec.deck, 0);
		int card1 = this.deck[num1];
		int card2 = sec.deck[num2];
		if (card1 > card2) { 
			this.deck[num1 + 1] = card2;
			sec.deck[num2] = 0;
		}
		if (card1 < card2)
        {
			sec.deck[num2 + 1] = card1;
			this.deck[num1] = 0;
		}
        else
        {
			war(sec, num1, num2);
        }

	}
}
class Program
{
	public static void Main()
	{
		Console.WriteLine("сережа абизян");
	}
}
