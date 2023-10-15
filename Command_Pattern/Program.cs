using Command_Pattern.Commands;
using Command_Pattern.Invokers;
using Command_Pattern.Receivers;

// Create Receiver
Chef chef = new Chef();

// Create Command
ICommand placeOrderCommand = new PlaceOrderCommand(chef);
ICommand cancelOrderCommand = new CancelOrderCommand(chef);

// Create Invoker
Waiter waiter = new Waiter();

// Placing an order
waiter.SetCommand(placeOrderCommand);
waiter.ExecuteCommand();

// Canceling the order
waiter.SetCommand(cancelOrderCommand);
waiter.ExecuteCommand();
