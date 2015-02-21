﻿using BlueSheep.Common.Protocol.Messages;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.Types;
using BlueSheep.Interface;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Core.Storage
{
    public class Leaving
    {
        #region Attributs
        private AccountUC account;
        #endregion

        #region Méthodes publiques

        public Leaving(AccountUC accountform)
        {
            account = accountform;
        }

        public void Init()
        {
            int quantity = 0;
            int objectUID = 0;

            foreach (BlueSheep.Core.Inventory.Item item in account.Inventory.Items)
            {
                bool isFood = false;

                foreach (Pet pet in account.petsList)
                {
                    foreach (Food food in pet.FoodList)
                    {
                        if (item.UID == food.Informations.UID)
                        {
                            isFood = true;
                            break;
                        }
                    }
                }

                if (isFood)
                {
                    quantity = item.Quantity;
                    objectUID = item.UID;
                    break;
                }
            }

            if (objectUID == 0)
            {
                account.Running.GettingFoodFromSafe();
                return;
            }

            account.Running.OnLeaving = true;

            ExchangeObjectMoveMessage exchangeObjectMoveMessage =
                new ExchangeObjectMoveMessage(objectUID, quantity);

            using (BigEndianWriter writer = new BigEndianWriter())
            {
                exchangeObjectMoveMessage.Serialize(writer);

                MessagePackaging messagePackaging = new MessagePackaging(writer);

                messagePackaging.Pack((int)exchangeObjectMoveMessage.ProtocolID);

                account.SocketManager.Send(messagePackaging.Writer.Content);
                account.LastPacketID.Clear();
            }
        }
        #endregion
    }
}
