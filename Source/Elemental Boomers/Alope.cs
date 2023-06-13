namespace Elemental_Boomers;

public class Alope
{
    public static float DeathRadius(int lifeStage)
    {
        float radius;

        switch (lifeStage)
        {
            case 0:
                radius = 1.9f;
                break;
            case 1:
                radius = 2.9f;
                break;
            default:
                radius = 4.9f;
                break;
        }

        return radius;
    }
}