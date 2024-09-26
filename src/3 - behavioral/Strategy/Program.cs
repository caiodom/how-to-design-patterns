
using Strategy;

Order order = new Order(new PayPalPaymentStrategy());
order.ProcessOrderPayment(100); // Pagamento de $100 via PayPal

// O cliente decide mudar para Cartão de Crédito
order.SetPaymentStrategy(new CreditCardPaymentStrategy());
order.ProcessOrderPayment(100); // Pagamento de $100 via Cartão de Crédito

// O cliente decide mudar para Bitcoin
order.SetPaymentStrategy(new BitcoinPaymentStrategy());
order.ProcessOrderPayment(100); // Pagamento de $100 via Bitcoin