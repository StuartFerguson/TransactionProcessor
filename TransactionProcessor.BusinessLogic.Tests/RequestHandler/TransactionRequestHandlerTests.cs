﻿namespace TransactionProcessor.BusinessLogic.Tests.CommandHandler
{
    using System.Threading;
    using BusinessLogic.Services;
    using Commands;
    using MediatR;
    using Moq;
    using RequestHandlers;
    using Requests;
    using Services;
    using Shared.DomainDrivenDesign.CommandHandling;
    using Shouldly;
    using Testing;
    using Xunit;

    public class TransactionRequestHandlerTests
    {
        [Fact]
        public void TransactionRequestHandler_ProcessLogonTransactionRequest_IsHandled()
        {
            Mock<ITransactionDomainService> transactionDomainService = new Mock<ITransactionDomainService>();
            TransactionRequestHandler handler = new TransactionRequestHandler(transactionDomainService.Object);

            ProcessLogonTransactionRequest command = TestData.ProcessLogonTransactionRequest;

            Should.NotThrow(async () =>
                            {
                                await handler.Handle(command, CancellationToken.None);
                            });

        }
    }
}