IntegrationTest(Case case)
{
    ArrangeConfig();
    ArrangeKitchenAndBrand();

    SetupKitchenResponse();
    SetupAggregatorResponse();

    TriggerMenuUpdate(case); // case.MENU_PAYLOAD        

    AssertMenuToAggregator(case); // case.AGGREGATOR_MENU

    TriggerIncomingOrder(case); // case.AGGREGATOR_ORDER

    AssertOrderCreatedInKitchen(case); // case.CREATE_KITCHEN_ORDER
}

IntegrationTest(Case.SIMPLE_ITEMS);
IntegrationTest(Case.ITEM_WITH_MODIFICATIONS);

// other cases:
// SIMPLE_ORDER_WITH_OWN_DELIVERY,
// SIMPLE_ORDER_WITH_AGGREGATOR_DELIVERY