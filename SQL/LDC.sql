
SELECT 
b.Business,
COALESCE(p.StreetNo,'') as StreetNo,
p.Street,
p.Postcode,
Sum([Count]) as FootfallCount
FROM Businesses b 
	INNER JOIN Premises p on b.Id = p.BusinessId
	INNER JOIN Footfall f on p.Id = f.PremisesId
Group By b.Business, p.StreetNo,p.Street,p.Postcode
