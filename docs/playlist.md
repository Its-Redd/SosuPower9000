# Playlist til S3 eksamen (19/06/2024)

1. Hej

2. GitHub Projects
   - Issues

### Projekt Planlægning

3. Inception
   - Mål & Vision for projektet
4. Ellaboration
   - uddybelse (Krav specifikation)
5. Construction
   - Byg programmet
6. Testing
    - Unit Testing

### Kode eksempler

8. Klient
   - Design (Adobe XD)
   - Teknologi (MAUI)
     - Hvorfor?
   - MVVM (Model View Viemodel)
      - Seperation of concerns

### OOP
   - Polymorfi
      - Interfaces
        - Interfaces definerer en kontrakt, som klasser skal implementere.
        - De tillader polymorfi ved at flere klasser kan implementere samme interface og dermed behandles ens.
      - Generics
        - Generics tillader, at klasser og metoder kan operere på objekter af forskellige typer
        - Anvendes til at skabe kode, der kan genbruges med forskellige datatyper uden at miste type sikkerhed.
- Nedarvning
      - Constructor Chaining
      - Method overriding

##### API lag
   - Controllers
     - Seperation of concerns
   - Dependency Injection (Program.cs)
#####  Repository lag
   - DataContext
   - Repository klasse
     - Hvorfor bruger nogle controllers standard repository, og andre ikke? (specialiserede repositories)
   - Entity Framework
     - Code first tilgang (Start med at lave dine entititer)
##### Service lag
- ApiBase til at kommunikere med API
- Specialiserede services
