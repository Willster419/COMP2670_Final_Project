//one for gsm, one for cdma
select DISTINCT Phone.name, Network.type
 from Phone
  inner join PhoneCarrier on Phone.phoneID=PhoneCarrier.phoneID
  inner join Carrier on Carrier.carrierID=PhoneCarrier.carrierID
  inner join Network on Network.networkID=Carrier.NetworkID
  inner join SIM on SIM.phoneID=Phone.phoneID
where Network.type='GSM'
//one for both