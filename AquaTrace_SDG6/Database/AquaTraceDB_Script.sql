USE AquaTrace_DB;
GO

-- Table 1: WaterSources
CREATE TABLE WaterSources (
    SourceID      INT           PRIMARY KEY IDENTITY(1,1),
    SourceName    NVARCHAR(100) NOT NULL,
    Location      NVARCHAR(150) NOT NULL,
    SourceType    NVARCHAR(50)  NOT NULL,
    Status        NVARCHAR(50)  NOT NULL,
    CoverageHH    INT           NOT NULL,
    LastInspected DATETIME      NOT NULL
);
GO

-- Table 2: MaintenanceLogs (FK → WaterSources)
CREATE TABLE MaintenanceLogs (
    LogID            INT           PRIMARY KEY IDENTITY(1,1),
    SourceID         INT           NOT NULL,
    MaintenanceDate  DATETIME      NOT NULL,
    TechnicianName   NVARCHAR(100) NOT NULL,
    IssueDescription NVARCHAR(255) NOT NULL,
    ActionTaken      NVARCHAR(255) NOT NULL,
    Cost             DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (SourceID) REFERENCES WaterSources(SourceID)
);
GO

-- Table 3: Users
CREATE TABLE Users (
    UserID   INT           PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50)  NOT NULL,
    Password NVARCHAR(50)  NOT NULL,
    Role     NVARCHAR(20)  NOT NULL,
    FullName NVARCHAR(100) NOT NULL
);
GO

-- Default Admin and Standard User accounts
INSERT INTO Users (Username, Password, Role, FullName)
VALUES ('admin', 'admin123', 'Admin', 'System Administrator');

INSERT INTO Users (Username, Password, Role, FullName)
VALUES ('user1', 'user123', 'Standard', 'Standard User');
GO

-- Sample Water Sources
INSERT INTO WaterSources (SourceName, Location, SourceType, Status, CoverageHH, LastInspected)
VALUES ('Barangay Pump 1', 'Brgy. San Jose', 'Pump', 'Active', 120, '2026-01-15');

INSERT INTO WaterSources (SourceName, Location, SourceType, Status, CoverageHH, LastInspected)
VALUES ('Deep Well A', 'Brgy. Sta. Cruz', 'Well', 'Needs Repair', 85, '2025-11-20');

INSERT INTO WaterSources (SourceName, Location, SourceType, Status, CoverageHH, LastInspected)
VALUES ('Reservoir North', 'Brgy. Poblacion', 'Reservoir', 'Active', 340, '2026-03-10');
GO
