﻿using System;
using Domain.Common;

namespace Domain.Entites;

public sealed class Card:Entity
{
    public CardType Color { get; set; }
    public DateTime ReceptionDate { get; set; }
}

