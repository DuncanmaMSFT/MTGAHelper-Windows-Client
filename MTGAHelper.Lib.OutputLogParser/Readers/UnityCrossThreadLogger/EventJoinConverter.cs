﻿using System.Collections.Generic;
using MTGAHelper.Entity.OutputLogParsing;
using MTGAHelper.Lib.OutputLogParser.Models.UnityCrossThreadLogger;

namespace MTGAHelper.Lib.OutputLogParser.Readers.UnityCrossThreadLogger
{
    public class EventJoinConverter : GenericConverter<EventJoinResult, PayloadRaw2<EventJoinPayloadRaw>>, IMessageReaderUnityCrossThreadLogger
    {
        public override string LogTextKey => "<== Event_Join";
    }
}