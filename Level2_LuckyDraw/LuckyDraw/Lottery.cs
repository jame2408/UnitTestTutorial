namespace LuckyDraw;

public class Lottery
{
    /// <summary>
    /// Draw a winner from a list of participants.
    /// </summary>
    /// <param name="participants"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public string DrawWinner(List<string> participants)
    {
        if (participants.Any() == false)
        {
            throw new InvalidOperationException("No participants in the lottery");
        }
        
        var winnerIndex = Random.Shared.Next(participants.Count);
        return participants[winnerIndex];
    }
}