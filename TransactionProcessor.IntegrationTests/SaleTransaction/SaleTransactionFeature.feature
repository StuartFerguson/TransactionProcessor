﻿@base @shared
Feature: SaleTransaction

Background: 

	Given the following api resources exist
	| ResourceName     | DisplayName            | Secret  | Scopes           | UserClaims                 |
	| estateManagement | Estate Managememt REST | Secret1 | estateManagement | MerchantId, EstateId, role |
	| transactionProcessor | Transaction Processor REST | Secret1 | transactionProcessor |  |

	Given the following clients exist
	| ClientId      | ClientName     | Secret  | AllowedScopes    | AllowedGrantTypes  |
	| serviceClient | Service Client | Secret1 | estateManagement,transactionProcessor | client_credentials |

	Given I have a token to access the estate management and transaction processor resources
	| ClientId      | 
	| serviceClient | 

	Given I have created the following estates
	| EstateName    |
	| Test Estate 1 |
	| Test Estate 2 |

	Given I have created the following operators
	| EstateName    | OperatorName | RequireCustomMerchantNumber | RequireCustomTerminalNumber |
	| Test Estate 1 | Safaricom    | True                        | True                        |

	Given I create the following merchants
	| MerchantName    | AddressLine1   | Town     | Region      | Country        | ContactName    | EmailAddress                 | EstateName    |
	| Test Merchant 1 | Address Line 1 | TestTown | Test Region | United Kingdom | Test Contact 1 | testcontact1@merchant1.co.uk | Test Estate 1 |
	| Test Merchant 2 | Address Line 1 | TestTown | Test Region | United Kingdom | Test Contact 2 | testcontact2@merchant2.co.uk | Test Estate 1 |
	| Test Merchant 3 | Address Line 1 | TestTown | Test Region | United Kingdom | Test Contact 3 | testcontact3@merchant2.co.uk | Test Estate 2 |

	Given I have assigned the following  operator to the merchants
	| OperatorName | MerchantName    | MerchantNumber | TerminalNumber | EstateName    |
	| Safaricom    | Test Merchant 1 | 00000001       | 10000001       | Test Estate 1 |

	Given I have assigned the following devices to the merchants
	| DeviceIdentifier | MerchantName    | EstateName    |
	| 123456780        | Test Merchant 1 | Test Estate 1 |
	| 123456781        | Test Merchant 2 | Test Estate 1 |
	| 123456782        | Test Merchant 3 | Test Estate 2 |

@PRTest
Scenario: Sale Transactions

	When I perform the following transactions
	| DateTime | TransactionNumber | TransactionType | MerchantName    | DeviceIdentifier | EstateName    | OperatorName | TransactionAmount |
	| Today    | 1                 | Sale            | Test Merchant 1 | 123456780        | Test Estate 1 | Safaricom    | 100.00            |
	| Today    | 2                 | Sale            | Test Merchant 2 | 123456781        | Test Estate 1 | Safaricom    | 100.00            |
	| Today    | 3                 | Sale            | Test Merchant 3 | 123456782        | Test Estate 2 | Safaricom    | 100.00            |
	
	Then transaction response should contain the following information
	| EstateName    | MerchantName    | TransactionNumber | ResponseCode | ResponseMessage |
	| Test Estate 1 | Test Merchant 1 | 1                 | 0000         | SUCCESS         |
	| Test Estate 1 | Test Merchant 2 | 2                 | 0000         | SUCCESS         |
	| Test Estate 2 | Test Merchant 3 | 3                 | 0000         | SUCCESS         |

@PRTest
Scenario: Sale Transaction with Invalid Device

	When I perform the following transactions
	| DateTime | TransactionNumber | TransactionType | MerchantName    | DeviceIdentifier | EstateName    | OperatorName | TransactionAmount |
	| Today    | 1                 | Sale            | Test Merchant 1 | 123456781        | Test Estate 1 | Safaricom    | 100.00            |
	
	Then transaction response should contain the following information
	| EstateName    | MerchantName    | TransactionNumber | ResponseCode | ResponseMessage                                                    |
	| Test Estate 1 | Test Merchant 1 | 1                 | 1000         | Device Identifier 123456781 not valid for Merchant Test Merchant 1 |

Scenario: Sale Transaction with Invalid Estate

	When I perform the following transactions
	| DateTime | TransactionNumber | TransactionType | MerchantName    | DeviceIdentifier | EstateName    |OperatorName |TransactionAmount |
	| Today    | 1                 | Sale           | Test Merchant 1 | 123456780       | InvalidEstate |Safaricom    | 100.00            |
	
	Then transaction response should contain the following information
	| EstateName    | MerchantName    | TransactionNumber | ResponseCode | ResponseMessage                                                        |
	| InvalidEstate | Test Merchant 1 | 1                 | 1001         | Estate Id [79902550-64df-4491-b0c1-4e78943928a3] is not a valid estate |

Scenario: Sale Transaction with Invalid Merchant

	When I perform the following transactions
	| DateTime | TransactionNumber | TransactionType | MerchantName    | DeviceIdentifier | EstateName    |OperatorName |TransactionAmount |
	| Today    | 1                 | Sale           | InvalidMerchant | 123456780        | Test Estate 1 |Safaricom    | 100.00            |
	
	Then transaction response should contain the following information
	| EstateName    | MerchantName    | TransactionNumber | ResponseCode | ResponseMessage                                                                                       |
	| Test Estate 1 | InvalidMerchant | 1                 | 1002         | Merchant Id [d59320fa-4c3e-4900-a999-483f6a10c69a] is not a valid merchant for estate [Test Estate 1] |
