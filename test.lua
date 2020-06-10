DuelLayout = UnityEngine.GameObject.Find("DuelLayout(Clone)")
Duel = DuelLayout:GetComponent("DuelEvent")
duelData = Duel.duelData

function c71703785()
    if(c71703785condition1()) then
        c71703785cost1()
        c71703785effect1()
        Duel:SetTriggerEffect(1, true)
    end
    if(c71703785condition2()) then
        local buff = c71703785buff2()
        Duel:SetContinuousEffect(buff)
    end
    if(c71703785condition3()) then
        c71703785effect3()
        Duel:SetTriggerEffect(3)
    end
end

function c71703785condition1()
    return Duel:DrawnCard("")
end

function c71703785cost1()
    Duel:ShowCard(Duel.thiscard)
end

function c71703785effect1()
    Duel:SpecialSummon(Duel.thiscard)
end

function c71703785condition2()
    if(duelData.duelPhase == GamePhase.damageStepStart) then
    if(Duel:ThisCardIsBattle()) then
    if(Duel:GetAntiMonster().attribute == "暗") then
        return true
    end
    end
    end
    return false
end

function c71703785effect2()
    Duel.thiscard.atk = Duel.thiscard.atk * 2
end

function c71703785buff2()
    local buff = Duel:CreateDuelBuff(2)
    buff:SetConTime(duelData.turnNum, GamePhase.damageStepEnd)
    buff:SetBuff(BuffType.atknew)
    return buff
end

function c71703785condition3()
    if(Duel:InCase(Duel.thiscard, GameEvent.battledestroy, 1)) then
        return true
    end
    if(Duel:InCase(Duel.thiscard, GameEvent.effectdestroy, 1)) then
        return true
    end
    return false
end

function c71703785effect3()
    local targetcard = TargetCard.New()
    targetcard:SetPosition(CardPosition.handcard)
    targetcard:SetPosition(CardPosition.deck)
    targetcard:SetPosition(CardPosition.grave)
    targetcard:SetTarget(GameCard.name, "黑魔术师")
    Duel:SelectCard(targetcard, 1, GameEvent.specialsummon)
end

function c54250060()
end

function c92510265()
end

function c19508728()
end

function c84877802()
end

function c94004268()
end

function c54749427()
end

function c20501450()
end
