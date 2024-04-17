test(Case case)
{
    ArrangeConfig();
    ArrangeKitchenAndBrand();

    SetupKitchenResponse();
    SetupAggregatorResponse();

    TriggerMenuUpdate(case); // case.

    AssertMenuToAggregator(case); // case.

    TriggerIncomingOrder(case); // case.

    AssertOrderCreatedInKitchen(case); // case.
}