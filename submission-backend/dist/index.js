"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = __importDefault(require("express"));
const body_parser_1 = __importDefault(require("body-parser"));
const fs_1 = __importDefault(require("fs"));
const app = (0, express_1.default)();
const PORT = 3000;
const DB_FILE = './src/db.json';
app.use(body_parser_1.default.json());
// Ensure db.json file exists
if (!fs_1.default.existsSync(DB_FILE)) {
    fs_1.default.writeFileSync(DB_FILE, JSON.stringify({ submissions: [] }, null, 2));
}
// /ping endpoint
app.get('/ping', (req, res) => {
    res.json(true);
});
// /submit endpoint
app.post('/submit', (req, res) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;
    // Read current submissions
    const db = JSON.parse(fs_1.default.readFileSync(DB_FILE, 'utf-8'));
    // Add new submission
    db.submissions.push({ name, email, phone, github_link, stopwatch_time });
    // Save to db.json
    fs_1.default.writeFileSync(DB_FILE, JSON.stringify(db, null, 2));
    res.status(201).json({ message: 'Submission saved successfully' });
});
// /read endpoint
app.get('/read', (req, res) => {
    const index = parseInt(req.query.index);
    // Read current submissions
    const db = JSON.parse(fs_1.default.readFileSync(DB_FILE, 'utf-8'));
    // Return the requested submission
    if (index >= 0 && index < db.submissions.length) {
        res.json(db.submissions[index]);
    }
    else {
        res.status(404).json({ error: 'Submission not found' });
    }
});
app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
