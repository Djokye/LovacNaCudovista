
INSERT ALL
INTO Cudoviste (IdCudovista, NazivCud, PodTipCud, VekPomCud) VALUES (1, 'Zmaj', 'Mitsko bice', 1200)
INTO Cudoviste (IdCudovista, NazivCud, PodTipCud, VekPomCud) VALUES (2, 'Vukodlak', 'Natprirodno bice', 400)
INTO Cudoviste (IdCudovista, NazivCud, PodTipCud, VekPomCud) VALUES (3, 'Vampir', 'Natprirodno bice', 600)
INTO Cudoviste (IdCudovista, NazivCud, PodTipCud, VekPomCud) VALUES (4, 'Vila Raviojla', 'Mitsko bice', 150)
INTO Cudoviste (IdCudovista, NazivCud, PodTipCud, VekPomCud) VALUES (5, 'Meduza', 'Mitsko bice', 300)
SELECT * FROM dual;


INSERT ALL
INTO SpecSposobnost (IdSpecSpos, NazivSpecSpos) VALUES (1, 'Vatreni dah')
INTO SpecSposobnost (IdSpecSpos, NazivSpecSpos) VALUES (2, 'Transformacija u vuka')
INTO SpecSposobnost (IdSpecSpos, NazivSpecSpos) VALUES (3, 'Hipnotički pogled')
INTO SpecSposobnost (IdSpecSpos, NazivSpecSpos) VALUES (4, 'Leteće čari')
INTO SpecSposobnost (IdSpecSpos, NazivSpecSpos) VALUES (5, 'Pogled u kamen')
SELECT * FROM dual;


INSERT ALL
INTO MagSposobnost (IdMagSpos, NazivMagSpos, OpisMagSpos, Ofanzivna, Defanzivna) VALUES (1, 'Vatrena magija', 'Zmaj vatreni udar', 'da', 'ne')
INTO MagSposobnost (IdMagSpos, NazivMagSpos, OpisMagSpos, Ofanzivna, Defanzivna) VALUES (2, 'Mesečeva magija', 'Vukodlak mesečeva moć', 'ne', 'da')
INTO MagSposobnost (IdMagSpos, NazivMagSpos, OpisMagSpos, Ofanzivna, Defanzivna) VALUES (3, 'Krvi magija', 'Vampir moć krvi', 'da', 'da')
INTO MagSposobnost (IdMagSpos, NazivMagSpos, OpisMagSpos, Ofanzivna, Defanzivna) VALUES (4, 'Prirodna magija', 'Vila Raviojla leteće čari', 'ne', 'da')
INTO MagSposobnost (IdMagSpos, NazivMagSpos, OpisMagSpos, Ofanzivna, Defanzivna) VALUES (5, 'Kamen pogled', 'Meduza pogubljujući pogled', 'da', 'da')
SELECT * FROM dual;


INSERT ALL
INTO Bajalica (IdBajalice, NazivBajalice, Zastita, Prednost) VALUES (1, 'Plameni štit', 'Štiti od vatre', 'Odbija napade')
INTO Bajalica (IdBajalice, NazivBajalice, Zastita, Prednost) VALUES (2, 'Mesečev talisman', 'Povećava snagu vukodlaka', 'Omogućava kontrolu transformacije')
INTO Bajalica (IdBajalice, NazivBajalice, Zastita, Prednost) VALUES (3, 'Krvni amulet', 'Štiti od vampira', 'Povećava moć')
INTO Bajalica (IdBajalice, NazivBajalice, Zastita, Prednost) VALUES (4, 'Krila vila', 'Omogućava letenje', 'Povećava magične sposobnosti')
INTO Bajalica (IdBajalice, NazivBajalice, Zastita, Prednost) VALUES (5, 'Ogledalo Meduze', 'Reflektuje pogled', 'Štiti od kamena')
SELECT * FROM dual;


INSERT ALL
INTO Lovac (IdLovca, ImeLovca) VALUES (1, 'Eragon')
INTO Lovac (IdLovca, ImeLovca) VALUES (2, 'Jacob Black')
INTO Lovac (IdLovca, ImeLovca) VALUES (3, 'Van Helsing')
INTO Lovac (IdLovca, ImeLovca) VALUES (4, 'Tinker Bell')
INTO Lovac (IdLovca, ImeLovca) VALUES (5, 'Persej')
SELECT * FROM dual;


INSERT ALL
INTO Predmet (IdPredmeta, TipPredmeta, NazivPredmeta, MaterijalPredmeta) VALUES (1, 'Oružje', 'Plamenik', 'Čelik')
INTO Predmet (IdPredmeta, TipPredmeta, NazivPredmeta, MaterijalPredmeta) VALUES (2, 'Oružje', 'Srebrni bodež', 'Srebro')
INTO Predmet (IdPredmeta, TipPredmeta, NazivPredmeta, MaterijalPredmeta) VALUES (3, 'Amajlija', 'Amulet krvi', 'Zlato')
INTO Predmet (IdPredmeta, TipPredmeta, NazivPredmeta, MaterijalPredmeta) VALUES (4, 'Magični predmet', 'Čarobni prah', 'Bilje')
INTO Predmet (IdPredmeta, TipPredmeta, NazivPredmeta, MaterijalPredmeta) VALUES (5, 'Ogledalo', 'Ogledalo Meduze', 'Staklo')
SELECT * FROM dual;


INSERT ALL
INTO Protivmere (IdProtivmere, NazivProtivmere, OpisProtivmere) VALUES (1, 'Zmajeva koplja', 'Efikasna protiv Zmaja')
INTO Protivmere (IdProtivmere, NazivProtivmere, OpisProtivmere) VALUES (2, 'Srebrni metak', 'Efikasan protiv Vukodlaka')
INTO Protivmere (IdProtivmere, NazivProtivmere, OpisProtivmere) VALUES (3, 'Svetlo i beli češnjak', 'Efikasno protiv Vampira')
INTO Protivmere (IdProtivmere, NazivProtivmere, OpisProtivmere) VALUES (4, 'Magijski prah', 'Efikasan protiv Vila')
INTO Protivmere (IdProtivmere, NazivProtivmere, OpisProtivmere) VALUES (5, 'Ogledalo', 'Efikasno protiv Meduze')
SELECT * FROM dual;


INSERT ALL
INTO PoznatiPredstavnik (JedinstvenoIme, Starost, IdCud) VALUES ('Smaug', 1000, 1)
INTO PoznatiPredstavnik (JedinstvenoIme, Starost, IdCud) VALUES ('Remus', 220, 2)
INTO PoznatiPredstavnik (JedinstvenoIme, Starost, IdCud) VALUES ('Drakula', 532, 3)
INTO PoznatiPredstavnik (JedinstvenoIme, Starost, IdCud) VALUES ('Raviojla', 150, 4)
INTO PoznatiPredstavnik (JedinstvenoIme, Starost, IdCud) VALUES ('Persej', 300, 5)
SELECT * FROM dual;


INSERT ALL
INTO Legenda (IdLegende, PrvoPominjanje, TekstLegende, ZemljaPorekla, ImePoznatogPred)
  VALUES (1, TO_DATE('1000-01-01 BC','YYYY-MM-DD "BC"'), 'Legenda o Zmaju', 'Kina', 'Smaug')
INTO Legenda (IdLegende, PrvoPominjanje, TekstLegende, ZemljaPorekla, ImePoznatogPred)
  VALUES (2, TO_DATE('0800-01-01 BC','YYYY-MM-DD "BC"'), 'Legenda o Vukodlaku', 'Evropa', 'Remus')
INTO Legenda (IdLegende, PrvoPominjanje, TekstLegende, ZemljaPorekla, ImePoznatogPred)
  VALUES (3, TO_DATE('0500-01-01 BC','YYYY-MM-DD "BC"'), 'Legenda o Vampiru', 'Rumunija', 'Drakula')
INTO Legenda (IdLegende, PrvoPominjanje, TekstLegende, ZemljaPorekla, ImePoznatogPred)
  VALUES (4, TO_DATE('1500-01-01','YYYY-MM-DD'), 'Legenda o Vili Raviojli', 'Francuska', 'Raviojla')
INTO Legenda (IdLegende, PrvoPominjanje, TekstLegende, ZemljaPorekla, ImePoznatogPred)
  VALUES (5, TO_DATE('0700-01-01 BC','YYYY-MM-DD "BC"'), 'Legenda o Meduzi', 'Grčka', 'Persej')
SELECT * FROM dual;

INSERT ALL
INTO Lokacija (IdLokacije, TipLok, NazivLok, ZemljaLok, Blago, IdLeg) VALUES (1, 'Planina', 'Krasna planina', 'Kina', 'Zlatni dragulji', 1)
INTO Lokacija (IdLokacije, TipLok, NazivLok, ZemljaLok, Blago, IdLeg) VALUES (2, 'Šuma', 'Pun mesec', 'Evropa', 'Retki kristali', 2)
INTO Lokacija (IdLokacije, TipLok, NazivLok, ZemljaLok, Blago, IdLeg) VALUES (3, 'Dvorac', 'Transilvanija', 'Rumunija', 'Blago i zlato', 3)
INTO Lokacija (IdLokacije, TipLok, NazivLok, ZemljaLok, Blago, IdLeg) VALUES (4, 'Livada', 'Raviojlina dolina', 'Francuska', 'Magične biljke', 4)
INTO Lokacija (IdLokacije, TipLok, NazivLok, ZemljaLok, Blago, IdLeg) VALUES (5, 'Pećina', 'Gorgonska pećina', 'Grčka', 'Oružje i artefakti', 5)
SELECT * FROM dual;


INSERT ALL
INTO Zastita (IdZastite, TipZastite, NazivZastite, IdLok) VALUES (1, 'Fizička', 'Zmaj štit', 1)
INTO Zastita (IdZastite, TipZastite, NazivZastite, IdLok) VALUES (2, 'Fizička', 'Srebrna oklop', 2)
INTO Zastita (IdZastite, TipZastite, NazivZastite, IdLok) VALUES (3, 'Magijska', 'Krvni amulet', 3)
INTO Zastita (IdZastite, TipZastite, NazivZastite, IdLok) VALUES (4, 'Magijska', 'Vila čarolija', 4)
INTO Zastita (IdZastite, TipZastite, NazivZastite, IdLok) VALUES (5, 'Magijska', 'Ogledalo Meduze', 5)
SELECT * FROM dual;


INSERT ALL
INTO MagCudoviste (IdCudovista, Postojanje) VALUES (1, 'da')
INTO MagCudoviste (IdCudovista, Postojanje) VALUES (4, 'da')
INTO MagCudoviste (IdCudovista, Postojanje) VALUES (5, 'da')
SELECT * FROM dual;

INSERT ALL
INTO NeMagCudoviste (IdCudovista, Visina, Duzina, Kandze, BrojGlava, ZiviUVodi, Leti, Otrovno, Tezina)
  VALUES (2, 200, 220, 'da', 1, 'ne', 'ne', 'ne', 80)
INTO NeMagCudoviste (IdCudovista, Visina, Duzina, Kandze, BrojGlava, ZiviUVodi, Leti, Otrovno, Tezina)
  VALUES (3, 180, 200, 'da', 1, 'ne', 'ne', 'da', 70)
SELECT * FROM dual;


INSERT ALL
INTO UsloviZaPrimenu (IdUslova, Uslov, IdProtivM) VALUES (1, 'Ubosti Zmaja kopljem', 1)
INTO UsloviZaPrimenu (IdUslova, Uslov, IdProtivM) VALUES (2, 'Pogoditi Vukodlaka srebrnim metkom', 2)
INTO UsloviZaPrimenu (IdUslova, Uslov, IdProtivM) VALUES (3, 'Približiti se Vampiru sa svetlom i češnjakom', 3)
INTO UsloviZaPrimenu (IdUslova, Uslov, IdProtivM) VALUES (4, 'Raspršiti magični prah na Vilu', 4)
INTO UsloviZaPrimenu (IdUslova, Uslov, IdProtivM) VALUES (5, 'Reflektovati pogled Meduze ogledalom', 5)
SELECT * FROM dual;


INSERT ALL
INTO ProtivmeraPosedujePredmet (IdPPP, IdPred, IdPM) VALUES (1, 1, 1)
INTO ProtivmeraPosedujePredmet (IdPPP, IdPred, IdPM) VALUES (2, 2, 2)
INTO ProtivmeraPosedujePredmet (IdPPP, IdPred, IdPM) VALUES (3, 3, 3)
INTO ProtivmeraPosedujePredmet (IdPPP, IdPred, IdPM) VALUES (4, 4, 4)
INTO ProtivmeraPosedujePredmet (IdPPP, IdPred, IdPM) VALUES (5, 5, 5)
SELECT * FROM dual;


INSERT ALL
INTO BajalicaProtivMagCud (IdBaj, IdCud, IdBajalicaPMagCud) VALUES (1, 1, 1)
INTO BajalicaProtivMagCud (IdBaj, IdCud, IdBajalicaPMagCud) VALUES (4, 4, 2)
INTO BajalicaProtivMagCud (IdBaj, IdCud, IdBajalicaPMagCud) VALUES (5, 5, 3)
SELECT * FROM dual;


INSERT ALL
INTO ProtivCud (IdProtivCud, IdCud, IdPM) VALUES (1, 1, 1)
INTO ProtivCud (IdProtivCud, IdCud, IdPM) VALUES (2, 2, 2)
INTO ProtivCud (IdProtivCud, IdCud, IdPM) VALUES (3, 3, 3)
INTO ProtivCud (IdProtivCud, IdCud, IdPM) VALUES (4, 4, 4)
INTO ProtivCud (IdProtivCud, IdCud, IdPM) VALUES (5, 5, 5)
SELECT * FROM dual;

INSERT ALL
INTO CudImaMagSpos (IdCud, IdMagicnaSpos, IdCudMagSpos) VALUES (1, 1, 1)
INTO CudImaMagSpos (IdCud, IdMagicnaSpos, IdCudMagSpos) VALUES (4, 4, 2)
INTO CudImaMagSpos (IdCud, IdMagicnaSpos, IdCudMagSpos) VALUES (5, 5, 3)
SELECT * FROM dual;


INSERT ALL
INTO CudImaSpecSpos (IdCud, IdSpecijalnaSpos, IdCudSpecSpos) VALUES (2, 2, 1)
INTO CudImaSpecSpos (IdCud, IdSpecijalnaSpos, IdCudSpecSpos) VALUES (3, 3, 2)
SELECT * FROM dual;


INSERT ALL
INTO PostojiLegenda (IdCud, IdLeg, IdPostojiLegenda) VALUES (1, 1, 1)
INTO PostojiLegenda (IdCud, IdLeg, IdPostojiLegenda) VALUES (2, 2, 2)
INTO PostojiLegenda (IdCud, IdLeg, IdPostojiLegenda) VALUES (3, 3, 3)
INTO PostojiLegenda (IdCud, IdLeg, IdPostojiLegenda) VALUES (4, 4, 4)
INTO PostojiLegenda (IdCud, IdLeg, IdPostojiLegenda) VALUES (5, 5, 5)
SELECT * FROM dual;


INSERT ALL
INTO LovacTragaPoznatimPred (IdLovacTragaPP, ImePP, IdLov) VALUES (1, 'Smaug', 1)
INTO LovacTragaPoznatimPred (IdLovacTragaPP, ImePP, IdLov) VALUES (2, 'Remus', 2)
INTO LovacTragaPoznatimPred (IdLovacTragaPP, ImePP, IdLov) VALUES (3, 'Drakula', 3)
INTO LovacTragaPoznatimPred (IdLovacTragaPP, ImePP, IdLov) VALUES (4, 'Raviojla', 4)
INTO LovacTragaPoznatimPred (IdLovacTragaPP, ImePP, IdLov) VALUES (5, 'Persej', 5)
SELECT * FROM dual;


INSERT ALL
INTO Susret (IdSusret, IdLov, ImePP, IdLok, Vreme, Ishod) VALUES (1, 1, 'Smaug',   1, TO_DATE('2023-06-01','YYYY-MM-DD'), 'Pobeda čudovišta')
INTO Susret (IdSusret, IdLov, ImePP, IdLok, Vreme, Ishod) VALUES (2, 2, 'Remus',   2, TO_DATE('2022-10-15','YYYY-MM-DD'), 'Poraz lovca')
INTO Susret (IdSusret, IdLov, ImePP, IdLok, Vreme, Ishod) VALUES (3, 3, 'Drakula', 3, TO_DATE('2023-01-20','YYYY-MM-DD'), 'Pobeda čudovišta')
INTO Susret (IdSusret, IdLov, ImePP, IdLok, Vreme, Ishod) VALUES (4, 4, 'Raviojla',4, TO_DATE('2023-03-05','YYYY-MM-DD'), 'Neodlučan ishod')
INTO Susret (IdSusret, IdLov, ImePP, IdLok, Vreme, Ishod) VALUES (5, 5, 'Persej',  5, TO_DATE('2022-12-10','YYYY-MM-DD'), 'Pobeda lovca')
SELECT * FROM dual;