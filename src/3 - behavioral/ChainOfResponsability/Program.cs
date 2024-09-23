using ChainOfResponsability;
using ChainOfResponsability.Handler;
using ChainOfResponsability.Handler.Interfaces;


var approvers = new Dictionary<int, IHandler>
{
     {1, new Level1Approver() },
    {2, new Level2Approver() },
    {3, new Level3Approver() }
};

var approvalChain = new ApprovalChain(approvers);

Console.WriteLine("==============FIRST REQUEST=======================");
approvalChain.StartChain(2500.00M);

Console.WriteLine("\n==============SECOND REQUEST=======================");
approvalChain.StartChain(500.00M);

Console.WriteLine("\n==============THIRD REQUEST=======================");
approvalChain.StartChain(9000.00M);