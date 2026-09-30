foreach (var status in new[] { "pending", "shipped", "lost", "" })
    Console.WriteLine(Label(status));

static string Label(string status) => status switch
{
    "pending" => "Waiting for payment",
    "shipped" or "in transit" => "On its way",
    "" => "No status recorded",
    _ => $"Unknown status: {status}",
};
