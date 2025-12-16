// This is a STATIC class: it stores state(badge achievement) for the current session and resets on every run.
// it lives only in memory. It tracks the bool status (BadgeCollected) landmarks
public static class GameProgress
{
    // assume a maximum of 4 badges for now (index 0, 1, 2, 3)
    private static bool[] badgesCollected = new bool[4];


    public static int BadgesCount = 0;

    // Checks if a badge (by its ID: 1, 2, 3, or 4) is already collected
    public static bool IsBadgeCollected(int landmarkId)
    {
        if (landmarkId > 0 && landmarkId <= badgesCollected.Length)
        {
            return badgesCollected[landmarkId - 1];
        }
        return false;
    }

    // Sets the badge as collected after a successful quiz
    public static void SetBadgeCollected(int landmarkId)
    {
        if (landmarkId > 0 && landmarkId <= badgesCollected.Length)
        {
            // Only update if the badge hasn't been collected yet
            if (!badgesCollected[landmarkId - 1])
            {
                badgesCollected[landmarkId - 1] = true;
                BadgesCount++;
            }
        }
    }

    // An optional reset function for a "Start New Game" button (or for demonstration)
    public static void ResetProgress()
    {
        for (int i = 0; i < badgesCollected.Length; i++)
        {
            badgesCollected[i] = false;
        }
        BadgesCount = 0;
    }
}