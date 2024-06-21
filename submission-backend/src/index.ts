import express, { Request, Response } from 'express';
import bodyParser from 'body-parser';
import fs from 'fs';

const app = express();
const PORT = 3000;
const DB_FILE = './src/db.json';

// Ensure db.json file exists
if (!fs.existsSync(DB_FILE)) {
    fs.writeFileSync(DB_FILE, JSON.stringify({ submissions: [] }, null, 2));
}

app.use(bodyParser.json());

// Function to load submissions from db.json
const loadSubmissions = (): any[] => {
    const data = fs.readFileSync(DB_FILE, 'utf-8');
    return JSON.parse(data).submissions;
};

// Function to save submissions to db.json
const saveSubmissions = (submissions: any[]): void => {
    fs.writeFileSync(DB_FILE, JSON.stringify({ submissions }, null, 2));
};

// /ping endpoint
app.get('/ping', (req: Request, res: Response) => {
    res.json(true);
});

// /submit endpoint
app.post('/submit', (req: Request, res: Response) => {
    console.log('Received data:', req.body); // Debug logging

    const { Name, Email, PhoneNumber, GitHubLink, StopwatchTime } = req.body;

    // Load current submissions
    const submissions = loadSubmissions();

    // Generate new ID
    const newId = submissions.length > 0 ? submissions[submissions.length - 1].id + 1 : 1;

    // Create new submission object with ID
    const newSubmission = {
        id: newId,
        Name,
        Email,
        PhoneNumber,
        GitHubLink,
        StopwatchTime
    };

    // Add new submission to submissions array
    submissions.push(newSubmission);

    // Save updated submissions to db.json
    saveSubmissions(submissions);

    res.status(201).json({ message: 'Submission saved successfully', submission: newSubmission });
});

// /read endpoint
app.get('/read', (req: Request, res: Response) => {
    const index = parseInt(req.query.index as string);

    // Load current submissions
    const submissions = loadSubmissions();

    // Return the requested submission
    if (index >= 0 && index < submissions.length) {
        res.json(submissions[index]);
    } else {
        res.status(404).json({ error: 'Submission not found' });
    }
});

app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
