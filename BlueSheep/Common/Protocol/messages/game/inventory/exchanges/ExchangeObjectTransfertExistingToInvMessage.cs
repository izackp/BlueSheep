









// Generated on 12/11/2014 19:01:50
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class ExchangeObjectTransfertExistingToInvMessage : Message
    {
        public new const uint ID =6326;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        
        public ExchangeObjectTransfertExistingToInvMessage()
        {
        }
        
        
        public override void Serialize(BigEndianWriter writer)
        {
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
        }
        
    }
    
}