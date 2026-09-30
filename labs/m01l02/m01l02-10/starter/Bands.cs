static class Bands
{
    public static string Statement(int qty)
    {
        switch (qty)
        {
            case 0: return "none";
            case 1: return "one";
            default: return "many";
        }
    }

    public static string Expression(int qty) => qty switch
    {
        0 => "none",
        1 => "one",
        _ => "many",
    };
}
