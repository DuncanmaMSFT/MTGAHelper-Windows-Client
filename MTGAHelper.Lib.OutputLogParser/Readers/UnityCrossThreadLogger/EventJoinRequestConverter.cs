﻿using MTGAHelper.Entity.OutputLogParsing;
using MTGAHelper.Lib.OutputLogParser.Models.UnityCrossThreadLogger.EventJoinRequest;

namespace MTGAHelper.Lib.OutputLogParser.Readers.UnityCrossThreadLogger
{
    public class EventJoinRequestConverter : GenericConverter<EventJoinRequestResult, RequestRaw2<EventJoinRequestPayloadRaw>>, IMessageReaderRequestToServer
    {
        public override string LogTextKey => "==> Event_Join";
    }
}