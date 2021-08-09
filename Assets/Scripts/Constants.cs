
public class Constants
{
    public static readonly float LEFT_BOUNDARY = -5.5f;  // platformun sol sınırının x koordinatı
    public static readonly float RIGHT_BOUNDARY = 5.5f;  // platformun sağ sınırının x koordinatı

    public static readonly float BALL_OFFSET = 1.7f;     // topların birbirleri arasındaki mesafe 
    public static readonly float SPHERE_RADIUS = 0.5f;   // yerde duran toplar toplandıktan sonra trigger özelliği kapanıncaki yarıçapları

    
    public static readonly float JUMP_AMOUNT = 4.5f; // player, engele geldiğinde zıplayacağı mesafe
    public static readonly float TOWERJUMP_AMOUNT = 8.5f;
    public class Animations
    {
        //Animasyonlar
        public const string IDLE_ANIMATION = "Idle";
        public const string RUN_ANIMATION = "Run";
        public const string JUMP_ANIMATION = "Jump";
        public const string TOWERJUMP_ANIMATION = "TowerJump";
        public const string FALL_ANIMATION = "Fall";
        public const string PENALTYKICK_ANIMATION = "PenaltyKick";
        public const string CHEERUP_ANIMATION = "CheerUp";

        //Finish Animation

        
    }
}
