CREATE TABLE [dbo].[FavGames_Table] (
    [Game_Name]        VARCHAR (30) NULL,
    [Release_Date]     INT          NULL,
    [Release_Platform] VARCHAR (25) NULL,
    [Hours_Played]     INT          NULL,
    [user_id]          INT          NULL,
    PRIMARY KEY CLUSTERED ([user_id] ASC)
);

