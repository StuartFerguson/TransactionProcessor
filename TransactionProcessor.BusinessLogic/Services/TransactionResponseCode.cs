﻿namespace TransactionProcessor.BusinessLogic.Services
{
    public enum TransactionResponseCode
    {
        Success = 0,
        
        InvalidDeviceIdentifier = 1000,
        InvalidEstateId = 1001,
        InvalidMerchantId = 1002,
        NoValidDevices = 1003,
        NoEstateOperators = 1004,
        OperatorNotValidForEstate = 1005,
        NoMerchantOperators = 1006,
        OperatorNotValidForMerchant = 1007,
        TransactionDeclinedByOperator = 1008,
        MerchantDoesNotHaveEnoughCredit = 1009,
        OperatorCommsError = 1010,
        InvalidSaleTransactionAmount = 1011,

        // A Catch All generic Error where reason has not been identified
        UnknownFailure = 9999
    }
}