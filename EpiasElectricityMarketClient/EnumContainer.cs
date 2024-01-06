using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasElectricityMarketClient
{

    public enum ActiveFullnessExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum ActiveVolumeExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum AmountOfBilateralContractsExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum AmountOfBlockBuyingExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum AmountOfBlockSellingExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum BidOfferQuantitiesExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum BilateralContractAmountExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum BilateralContractBuyExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum BilateralContractSellExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum CapacityDemandExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum ClearingQuantityExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum CongestionCostExportRequestDtoOrderType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"UP_REGULATION")]
        UP_REGULATION = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"DOWN_REGULATION")]
        DOWN_REGULATION = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"BOTH_REGULATIONS")]
        BOTH_REGULATIONS = 2,

    }


    public enum CongestionCostExportRequestDtoPriceType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"SMP")]
        SMP = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"MCP")]
        MCP = 1,

    }


    public enum CongestionCostExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum CongestionCostRequestDtoOrderType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"UP_REGULATION")]
        UP_REGULATION = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"DOWN_REGULATION")]
        DOWN_REGULATION = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"BOTH_REGULATIONS")]
        BOTH_REGULATIONS = 2,

    }


    public enum CongestionCostRequestDtoPriceType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"SMP")]
        SMP = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"MCP")]
        MCP = 1,

    }


    public enum ConsumerQuantityExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum ConsumptionQuantityExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum ContractPriceSummaryExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum DailyIndexPriceExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum DailyKotExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum DailyVolumeExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum DamDataExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum DayAheadMarketTradeVolumeExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum DemandForecastExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum DsgImbalanceQuantityExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum EakExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum EligibleConsumerCountExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum EligibleConsumerQuantityExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum EntsOrganizationExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum EntsowUevcbExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum FlexibleOfferBuySellExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum FrequencyCapacityAmountAndPriceExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum ImbalanceAmountExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum ImbalanceCostExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum ImbalanceQuantityExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum InjectionQuantityExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum InstalledCapacityExportRequestExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum InterconnectionLineCapacitiesExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum InterimMcpExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum InternationalLineEventExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum IskkExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum KgupExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum KudupExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum LicensedPowerPlantInvestmentExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum LoadEstimationPlanExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum MarketMessageSystemExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum MarketParticipantsExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum MatchedFlexibleOfferQuantityExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum MatchingQuantityExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum MaximumSettlementPriceExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum MeterCountExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum MeterCountSubjectToRetroactiveAdjustmentExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum MeterVolumeExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum MinMaxAskPriceExportRequestExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum MinMaxMatchingPriceExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum MinMaxOfferPriceExportRequestExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum ModelAndViewStatus
    {

        [System.Runtime.Serialization.EnumMember(Value = @"CONTINUE")]
        CONTINUE = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"SWITCHING_PROTOCOLS")]
        SWITCHING_PROTOCOLS = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PROCESSING")]
        PROCESSING = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"CHECKPOINT")]
        CHECKPOINT = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"OK")]
        OK = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"CREATED")]
        CREATED = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"ACCEPTED")]
        ACCEPTED = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"NON_AUTHORITATIVE_INFORMATION")]
        NON_AUTHORITATIVE_INFORMATION = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"NO_CONTENT")]
        NO_CONTENT = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"RESET_CONTENT")]
        RESET_CONTENT = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"PARTIAL_CONTENT")]
        PARTIAL_CONTENT = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"MULTI_STATUS")]
        MULTI_STATUS = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"ALREADY_REPORTED")]
        ALREADY_REPORTED = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"IM_USED")]
        IM_USED = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"MULTIPLE_CHOICES")]
        MULTIPLE_CHOICES = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"MOVED_PERMANENTLY")]
        MOVED_PERMANENTLY = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"FOUND")]
        FOUND = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"MOVED_TEMPORARILY")]
        MOVED_TEMPORARILY = 17,

        [System.Runtime.Serialization.EnumMember(Value = @"SEE_OTHER")]
        SEE_OTHER = 18,

        [System.Runtime.Serialization.EnumMember(Value = @"NOT_MODIFIED")]
        NOT_MODIFIED = 19,

        [System.Runtime.Serialization.EnumMember(Value = @"USE_PROXY")]
        USE_PROXY = 20,

        [System.Runtime.Serialization.EnumMember(Value = @"TEMPORARY_REDIRECT")]
        TEMPORARY_REDIRECT = 21,

        [System.Runtime.Serialization.EnumMember(Value = @"PERMANENT_REDIRECT")]
        PERMANENT_REDIRECT = 22,

        [System.Runtime.Serialization.EnumMember(Value = @"BAD_REQUEST")]
        BAD_REQUEST = 23,

        [System.Runtime.Serialization.EnumMember(Value = @"UNAUTHORIZED")]
        UNAUTHORIZED = 24,

        [System.Runtime.Serialization.EnumMember(Value = @"PAYMENT_REQUIRED")]
        PAYMENT_REQUIRED = 25,

        [System.Runtime.Serialization.EnumMember(Value = @"FORBIDDEN")]
        FORBIDDEN = 26,

        [System.Runtime.Serialization.EnumMember(Value = @"NOT_FOUND")]
        NOT_FOUND = 27,

        [System.Runtime.Serialization.EnumMember(Value = @"METHOD_NOT_ALLOWED")]
        METHOD_NOT_ALLOWED = 28,

        [System.Runtime.Serialization.EnumMember(Value = @"NOT_ACCEPTABLE")]
        NOT_ACCEPTABLE = 29,

        [System.Runtime.Serialization.EnumMember(Value = @"PROXY_AUTHENTICATION_REQUIRED")]
        PROXY_AUTHENTICATION_REQUIRED = 30,

        [System.Runtime.Serialization.EnumMember(Value = @"REQUEST_TIMEOUT")]
        REQUEST_TIMEOUT = 31,

        [System.Runtime.Serialization.EnumMember(Value = @"CONFLICT")]
        CONFLICT = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"GONE")]
        GONE = 33,

        [System.Runtime.Serialization.EnumMember(Value = @"LENGTH_REQUIRED")]
        LENGTH_REQUIRED = 34,

        [System.Runtime.Serialization.EnumMember(Value = @"PRECONDITION_FAILED")]
        PRECONDITION_FAILED = 35,

        [System.Runtime.Serialization.EnumMember(Value = @"PAYLOAD_TOO_LARGE")]
        PAYLOAD_TOO_LARGE = 36,

        [System.Runtime.Serialization.EnumMember(Value = @"REQUEST_ENTITY_TOO_LARGE")]
        REQUEST_ENTITY_TOO_LARGE = 37,

        [System.Runtime.Serialization.EnumMember(Value = @"URI_TOO_LONG")]
        URI_TOO_LONG = 38,

        [System.Runtime.Serialization.EnumMember(Value = @"REQUEST_URI_TOO_LONG")]
        REQUEST_URI_TOO_LONG = 39,

        [System.Runtime.Serialization.EnumMember(Value = @"UNSUPPORTED_MEDIA_TYPE")]
        UNSUPPORTED_MEDIA_TYPE = 40,

        [System.Runtime.Serialization.EnumMember(Value = @"REQUESTED_RANGE_NOT_SATISFIABLE")]
        REQUESTED_RANGE_NOT_SATISFIABLE = 41,

        [System.Runtime.Serialization.EnumMember(Value = @"EXPECTATION_FAILED")]
        EXPECTATION_FAILED = 42,

        [System.Runtime.Serialization.EnumMember(Value = @"I_AM_A_TEAPOT")]
        I_AM_A_TEAPOT = 43,

        [System.Runtime.Serialization.EnumMember(Value = @"INSUFFICIENT_SPACE_ON_RESOURCE")]
        INSUFFICIENT_SPACE_ON_RESOURCE = 44,

        [System.Runtime.Serialization.EnumMember(Value = @"METHOD_FAILURE")]
        METHOD_FAILURE = 45,

        [System.Runtime.Serialization.EnumMember(Value = @"DESTINATION_LOCKED")]
        DESTINATION_LOCKED = 46,

        [System.Runtime.Serialization.EnumMember(Value = @"UNPROCESSABLE_ENTITY")]
        UNPROCESSABLE_ENTITY = 47,

        [System.Runtime.Serialization.EnumMember(Value = @"LOCKED")]
        LOCKED = 48,

        [System.Runtime.Serialization.EnumMember(Value = @"FAILED_DEPENDENCY")]
        FAILED_DEPENDENCY = 49,

        [System.Runtime.Serialization.EnumMember(Value = @"UPGRADE_REQUIRED")]
        UPGRADE_REQUIRED = 50,

        [System.Runtime.Serialization.EnumMember(Value = @"PRECONDITION_REQUIRED")]
        PRECONDITION_REQUIRED = 51,

        [System.Runtime.Serialization.EnumMember(Value = @"TOO_MANY_REQUESTS")]
        TOO_MANY_REQUESTS = 52,

        [System.Runtime.Serialization.EnumMember(Value = @"REQUEST_HEADER_FIELDS_TOO_LARGE")]
        REQUEST_HEADER_FIELDS_TOO_LARGE = 53,

        [System.Runtime.Serialization.EnumMember(Value = @"UNAVAILABLE_FOR_LEGAL_REASONS")]
        UNAVAILABLE_FOR_LEGAL_REASONS = 54,

        [System.Runtime.Serialization.EnumMember(Value = @"INTERNAL_SERVER_ERROR")]
        INTERNAL_SERVER_ERROR = 55,

        [System.Runtime.Serialization.EnumMember(Value = @"NOT_IMPLEMENTED")]
        NOT_IMPLEMENTED = 56,

        [System.Runtime.Serialization.EnumMember(Value = @"BAD_GATEWAY")]
        BAD_GATEWAY = 57,

        [System.Runtime.Serialization.EnumMember(Value = @"SERVICE_UNAVAILABLE")]
        SERVICE_UNAVAILABLE = 58,

        [System.Runtime.Serialization.EnumMember(Value = @"GATEWAY_TIMEOUT")]
        GATEWAY_TIMEOUT = 59,

        [System.Runtime.Serialization.EnumMember(Value = @"HTTP_VERSION_NOT_SUPPORTED")]
        HTTP_VERSION_NOT_SUPPORTED = 60,

        [System.Runtime.Serialization.EnumMember(Value = @"VARIANT_ALSO_NEGOTIATES")]
        VARIANT_ALSO_NEGOTIATES = 61,

        [System.Runtime.Serialization.EnumMember(Value = @"INSUFFICIENT_STORAGE")]
        INSUFFICIENT_STORAGE = 62,

        [System.Runtime.Serialization.EnumMember(Value = @"LOOP_DETECTED")]
        LOOP_DETECTED = 63,

        [System.Runtime.Serialization.EnumMember(Value = @"BANDWIDTH_LIMIT_EXCEEDED")]
        BANDWIDTH_LIMIT_EXCEEDED = 64,

        [System.Runtime.Serialization.EnumMember(Value = @"NOT_EXTENDED")]
        NOT_EXTENDED = 65,

        [System.Runtime.Serialization.EnumMember(Value = @"NETWORK_AUTHENTICATION_REQUIRED")]
        NETWORK_AUTHENTICATION_REQUIRED = 66,

    }


    public enum MonthlySupplyPriceIndexExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum MultipleFactorExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum NominalCapacityExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum OrderSummaryDownExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum OrderSummaryUpExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum ParticipantCountBasedUponLicenseTypeExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum PercentageConsumptionInfoExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum PortfolioIncomeExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum PowerOutageExportRequestExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum PriceIndependentBidExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum PriceIndependentOfferExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum PtfExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum RealTimeConsumptionExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum RealtimeGenerationExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum RenewableLicencedGenerationAmountExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum RenewableResGenerationAndForecastExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum RenewableSmForecastExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum RenewableSmSpotOrderExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum RenewableSmUnitCostExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum RenewableUnlicencedGenerationAmountExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum RenewablesParticipantExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum RetroactiveAdjustmentSumExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum SidePaymentExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum SortDTODirection
    {

        [System.Runtime.Serialization.EnumMember(Value = @"ASC")]
        ASC = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"DESC")]
        DESC = 1,

    }


    public enum StAdediExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum StUecmExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum SubmittedBidOrderVolumeExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum SubmittedSalesOrderVolumeExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum SupplyDemandExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum SwvExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum SystemDirectionExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum SystemMarginalPriceExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum TcatPreMonthForecastExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum TcatPreYearForecastExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum TradeValueExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum TradeVolumeExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum TransactionHistoryExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum TransactionHistoryGipExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum UecmExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum VepMatchingQuantityExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum VepOfferPriceExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum VepOpenPositionExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum WaterEnergyProvisionExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum WeightedAveragePriceExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum WithdrawalQuantityExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum YekdemLuyExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum YekdemYekGeliriExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum YekdemYekbedExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum YekdemYektobExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum YekgExportedDocumentQuantityExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum YekgMatchAmountExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum YekgMinMaxMatchAmountExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum YekgOrderQuantityExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum YekgRedemptionAmountExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum YekgRepealAmountExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum YekgTradingVolumeExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum YekgWeightedAveragePriceExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }


    public enum ZeroBalanceExportRequestDtoExportType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"XLSX")]
        XLSX = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"CSV")]
        CSV = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PDF")]
        PDF = 2,

    }
}
