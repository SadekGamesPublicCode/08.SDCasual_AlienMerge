public class AdConfig
{
    public static string AppKey => GetAppKey();
    public static string BannerAdUnitId => GetBannerAdUnitId();
    public static string InterstitalAdUnitId => GetInterstitialAdUnitId();
    public static string RewardedVideoAdUnitId => GetRewardedVideoAdUnitId();
    static string GetAppKey()
    {
#if UNITY_ANDROID
        return "26fae7a5d";
#elif UNITY_IPHONE
            return "8545d445";
#else
            return "unexpected_platform";
#endif
    }
    static string GetBannerAdUnitId()
    {
#if UNITY_ANDROID
        return "95s0vy848voeekiz";
#elif UNITY_IPHONE
            return "iep3rxsyp9na3rw8";
#else
            return "unexpected_platform";
#endif
    }
    static string GetInterstitialAdUnitId()
    {
#if UNITY_ANDROID
        return "214ex2o00kgi03zj";
#elif UNITY_IPHONE
            return "wmgt0712uuux8ju4";
#else
            return "unexpected_platform";
#endif
    }
    static string GetRewardedVideoAdUnitId()
    {
#if UNITY_ANDROID
        return "qblqnun50hvekejg";
#elif UNITY_IPHONE
            return "qwouvdrkuwivay5q";
#else
            return "unexpected_platform";
#endif
    }
}
