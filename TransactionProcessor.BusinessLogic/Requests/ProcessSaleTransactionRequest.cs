﻿namespace TransactionProcessor.BusinessLogic.Requests
{
    using System;
    using System.Collections.Generic;
    using MediatR;
    using Models;

    public class ProcessSaleTransactionRequest : IRequest<ProcessSaleTransactionResponse>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessSaleTransactionRequest" /> class.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <param name="estateId">The estate identifier.</param>
        /// <param name="merchantId">The merchant identifier.</param>
        /// <param name="deviceIdentifier">The device identifier.</param>
        /// <param name="transactionType">Type of the transaction.</param>
        /// <param name="transactionDateTime">The transaction date time.</param>
        /// <param name="transactionNumber">The transaction number.</param>
        /// <param name="operatorIdentifier">The operator identifier.</param>
        /// <param name="customerEmailAddress">The customer email address.</param>
        /// <param name="additionalTransactionMetadata">The additional transaction metadata.</param>
        /// <param name="contractId">The contract identifier.</param>
        /// <param name="productId">The product identifier.</param>
        private ProcessSaleTransactionRequest(Guid transactionId,
                                              Guid estateId,
                                              Guid merchantId,
                                              String deviceIdentifier,
                                              String transactionType,
                                              DateTime transactionDateTime,
                                              String transactionNumber,
                                              String operatorIdentifier,
                                              String customerEmailAddress,
                                              Dictionary<String, String> additionalTransactionMetadata,
                                              Guid contractId,
                                              Guid productId)
        {
            this.TransactionId = transactionId;
            this.EstateId = estateId;
            this.DeviceIdentifier = deviceIdentifier;
            this.MerchantId = merchantId;
            this.TransactionDateTime = transactionDateTime;
            this.TransactionNumber = transactionNumber;
            this.OperatorIdentifier = operatorIdentifier;
            this.CustomerEmailAddress = customerEmailAddress;
            this.AdditionalTransactionMetadata = additionalTransactionMetadata;
            this.ContractId = contractId;
            this.ProductId = productId;
            this.TransactionType = transactionType;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the additional transaction metadata.
        /// </summary>
        /// <value>
        /// The additional transaction metadata.
        /// </value>
        public Dictionary<String, String> AdditionalTransactionMetadata { get; }

        /// <summary>
        /// Gets the customer email address.
        /// </summary>
        /// <value>
        /// The customer email address.
        /// </value>
        public String CustomerEmailAddress { get; }

        /// <summary>
        /// Gets the device identifier.
        /// </summary>
        /// <value>
        /// The device identifier.
        /// </value>
        public String DeviceIdentifier { get; }

        /// <summary>
        /// Gets the estate identifier.
        /// </summary>
        /// <value>
        /// The estate identifier.
        /// </value>
        public Guid EstateId { get; }

        /// <summary>
        /// Gets the merchant identifier.
        /// </summary>
        /// <value>
        /// The merchant identifier.
        /// </value>
        public Guid MerchantId { get; }

        /// <summary>
        /// Gets or sets the operator identifier.
        /// </summary>
        /// <value>
        /// The operator identifier.
        /// </value>
        public String OperatorIdentifier { get; }

        /// <summary>
        /// Gets the transaction date time.
        /// </summary>
        /// <value>
        /// The transaction date time.
        /// </value>
        public DateTime TransactionDateTime { get; }

        /// <summary>
        /// Gets the transaction identifier.
        /// </summary>
        /// <value>
        /// The transaction identifier.
        /// </value>
        public Guid TransactionId { get; }

        /// <summary>
        /// Gets the transaction number.
        /// </summary>
        /// <value>
        /// The transaction number.
        /// </value>
        public String TransactionNumber { get; }

        /// <summary>
        /// Gets the type of the transaction.
        /// </summary>
        /// <value>
        /// The type of the transaction.
        /// </value>
        public String TransactionType { get; }

        /// <summary>
        /// Gets the contract identifier.
        /// </summary>
        /// <value>
        /// The contract identifier.
        /// </value>
        public Guid ContractId { get; }

        /// <summary>
        /// Gets the product identifier.
        /// </summary>
        /// <value>
        /// The product identifier.
        /// </value>
        public Guid ProductId { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Creates the specified estate identifier.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <param name="estateId">The estate identifier.</param>
        /// <param name="merchantId">The merchant identifier.</param>
        /// <param name="deviceIdentifier">The device identifier.</param>
        /// <param name="transactionType">Type of the transaction.</param>
        /// <param name="transactionDateTime">The transaction date time.</param>
        /// <param name="transactionNumber">The transaction number.</param>
        /// <param name="operatorIdentifier">The operator identifier.</param>
        /// <param name="customerEmailAddress">The customer email address.</param>
        /// <param name="additionalTransactionMetadata">The additional transaction metadata.</param>
        /// <param name="contractId">The contract identifier.</param>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public static ProcessSaleTransactionRequest Create(Guid transactionId,
                                                           Guid estateId,
                                                           Guid merchantId,
                                                           String deviceIdentifier,
                                                           String transactionType,
                                                           DateTime transactionDateTime,
                                                           String transactionNumber,
                                                           String operatorIdentifier,
                                                           String customerEmailAddress,
                                                           Dictionary<String, String> additionalTransactionMetadata,
                                                           Guid contractId,
                                                           Guid productId)
        {
            return new ProcessSaleTransactionRequest(transactionId,
                                                     estateId,
                                                     merchantId,
                                                     deviceIdentifier,
                                                     transactionType,
                                                     transactionDateTime,
                                                     transactionNumber,
                                                     operatorIdentifier,
                                                     customerEmailAddress,
                                                     additionalTransactionMetadata,
                                                     contractId,
                                                     productId);
        }

        #endregion
    }
}